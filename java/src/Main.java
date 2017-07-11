import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.lang.reflect.Array;
import java.util.*;

public class Main extends JFrame {

    private static final int ELEMENT_COUNT = 1000;

    private JPanel panel;
    private JList<Integer> rawDataList;
    private JList<Integer> sortedDataList;
    private JButton generateRawButton;
    private JButton resetButton;
    private JLabel elementCountLabel;
    private JRadioButton ascSortRadioButton;
    private JRadioButton descSortRadioButton;
    private JButton sortButton;
    private JButton aboutButton;
    private JButton authorButton;
    private JButton saveButton;
    private JLabel sortTimeLabel;
    private JButton exitButton;

    private DefaultListModel<Integer> rawDataModel = new DefaultListModel<>();
    private DefaultListModel<Integer> sortedDataModel = new DefaultListModel<>();

    Main(Start start) {
        setTitle("Сортировка числовых данных методом подсчета");
        setContentPane(panel);
        setDefaultCloseOperation(WindowConstants.DO_NOTHING_ON_CLOSE);
        addWindowListener(new WindowAdapter() {
            @Override
            public void windowClosing(WindowEvent evt) {
                Main.this.setVisible(false);
                start.setVisible(true);
            }
        });
        pack();
        setVisible(true);

        ButtonGroup group = new ButtonGroup();
        group.add(ascSortRadioButton);
        group.add(descSortRadioButton);

        rawDataList.setModel(rawDataModel);
        sortedDataList.setModel(sortedDataModel);

        sortButton.addActionListener((ActionEvent e) -> {
            int[] array = new int[rawDataModel.getSize()];
            for (int i = 0; i < array.length; i++) {
                array[i] = rawDataModel.get(i);
            }
            long startNanoTime = System.nanoTime();
            if (ascSortRadioButton.isSelected()) {
                countingSort(array, true);
            } else {
                countingSort(array, false);
            }
            long elapsedTimeMilliseconds = (System.nanoTime() - startNanoTime) / 1000;
            sortedDataModel.clear();
            for (int i = 0; i < array.length; i++) {
                sortedDataModel.addElement(array[i]);
            }
            sortTimeLabel.setText("t = " + elapsedTimeMilliseconds + " ms");
        });
        generateRawButton.addActionListener((ActionEvent e) -> {
            Random random = new Random();
            for (int i = 0; i < ELEMENT_COUNT; i++) {
                rawDataModel.addElement(random.nextInt(ELEMENT_COUNT));
            }
        });
        resetButton.addActionListener((ActionEvent e) -> {
            rawDataModel.clear();
            sortedDataModel.clear();
        });
        saveButton.addActionListener((ActionEvent e) -> {
            JFileChooser fileChooser = new JFileChooser();
            if (fileChooser.showSaveDialog(null) == JFileChooser.APPROVE_OPTION) {
                try {
                    File file = fileChooser.getSelectedFile();
                    try (FileWriter writer = new FileWriter(file)) {
                        Enumeration<Integer> elements = sortedDataModel.elements();
                        while (elements.hasMoreElements()) {
                            writer.write(elements.nextElement() + "\n");
                        }
                    }
                } catch (IOException ex) {
                    ex.printStackTrace();
                }
            }
        });
        authorButton.addActionListener((ActionEvent e) -> new AboutAuthor().setVisible(true));
        aboutButton.addActionListener((ActionEvent e) -> new AboutProgram().setVisible(true));
        exitButton.addActionListener((ActionEvent e) -> System.exit(0));
    }

    private static void countingSort(int[] arr, boolean isAscending) {
        int[] aux = new int[arr.length];

        int min = arr[0];
        int max = arr[0];
        for (int i = 1; i < arr.length; i++) {
            if (arr[i] < min) {
                min = arr[i];
            } else if (arr[i] > max) {
                max = arr[i];
            }
        }

        int[] counts = new int[max - min + 1];

        for (int i = 0;  i < arr.length; i++) {
            counts[arr[i] - min]++;
        }

        counts[0]--;
        for (int i = 1; i < counts.length; i++) {
            counts[i] = counts[i] + counts[i-1];
        }
        for (int i = arr.length - 1; i >= 0; i--) {
            aux[counts[arr[i] - min]--] = arr[i];
        }

        System.arraycopy( aux, 0, arr, 0, aux.length );

        if (!isAscending) {
            arr = reverseArray(arr);
        }
    }

    private static int[] reverseArray(int [] array) {
        for(int i = 0; i < array.length / 2; i++) {
            int temp = array[i];
            array[i] = array[array.length - i - 1];
            array[array.length - i - 1] = temp;
        }

        return array;
    }

    private static int findMaxInArray(int[] array) {
        int max = array[0];

        for (int i = 1; i < array.length; i++) {
            if (array[i] > max) {
                max = array[i];
            }
        }

        return max;
    }


}
