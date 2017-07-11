import javax.swing.*;
import java.awt.event.ActionEvent;

public class Start extends JFrame {

    private JButton startButton;
    private JPanel panel;

    private Start() {
        setTitle("Сортировка числовых данных методом подсчета");
        setContentPane(panel);
        setDefaultCloseOperation(WindowConstants.EXIT_ON_CLOSE);
        pack();

        startButton.addActionListener((ActionEvent e) -> {
            Main main = new Main(this);
            Start.this.setVisible(false);
            main.setVisible(true);
        });
    }

    public static void main(String[] args) {
        try {
            UIManager.setLookAndFeel("com.sun.java.swing.plaf.windows.WindowsLookAndFeel");
        } catch (ClassNotFoundException | InstantiationException | IllegalAccessException | UnsupportedLookAndFeelException e) {
            e.printStackTrace();
        }
        new Start().setVisible(true);
    }

}
