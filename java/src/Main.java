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
    private JTextField nElementCountTextField;

    private DefaultListModel<Integer> rawDataModel = new DefaultListModel<>();
    private DefaultListModel<Integer> sortedDataModel = new DefaultListModel<>();

    Main() {
        setTitle("Сортировка числовых данных методом подсчета");
        setContentPane(panel);
        pack();
        setVisible(true);

        ButtonGroup group = new ButtonGroup();
        group.add(ascSortRadioButton);
        group.add(descSortRadioButton);

        rawDataList.setModel(rawDataModel);
        sortedDataList.setModel(sortedDataModel);

        sortButton.addActionListener((ActionEvent e) -> {
            int[] array = new int[rawDataModel.getSize()];
            if (array.length == 0) {
                return;
            }
            for (int i = 0; i < array.length; i++) {
                array[i] = rawDataModel.get(i);
            }
            long startNanoTime = System.nanoTime();
            if (ascSortRadioButton.isSelected()) {
                countingSort(array, true);
            } else {
                countingSort(array, false);
            }
            long elapsedTimeMilliseconds = (System.nanoTime() - startNanoTime) / 10000;
            sortedDataModel.clear();
            for (int i = 0; i < array.length; i++) {
                sortedDataModel.addElement(array[i]);
            }
            sortTimeLabel.setText("t = " + elapsedTimeMilliseconds + " ms");
        });
        generateRawButton.addActionListener((ActionEvent e) -> {
            Random random = new Random();
            int n;
            try {
                n = Integer.parseInt(nElementCountTextField.getText());
            } catch (NumberFormatException error) {
                return;
            }
            rawDataModel.clear();
            for (int i = 0; i < n; i++) {
                rawDataModel.addElement(random.nextInt(n) + 1);
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
        int k = findMaxInArray(arr);
        int[] zeroArray = new int[k];
        int n = arr.length;

        for (int i = 0; i < n; i++) {
            zeroArray[arr[i] - 1] = zeroArray[arr[i] - 1] + 1;
        }

        int b = 0;
        for (int j = 0; j < k; j++) {
            for (int i = 0; i < zeroArray[j]; i++) {
                arr[b] = j + 1;
                b = b + 1;
            }
        }

        if (isAscending == false) {
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

    public static void main(String[] args) {
        Main main = new Main();
        main.setVisible(true);
    }
}
