import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

public class AboutProgram extends JFrame {

    private JPanel panel;
    private JButton okButton;

    AboutProgram() {
        setTitle("О программе");
        setContentPane(panel);
        setDefaultCloseOperation(WindowConstants.DO_NOTHING_ON_CLOSE);
        addWindowListener(new WindowAdapter() {
            @Override
            public void windowClosing(WindowEvent evt) {
                AboutProgram.this.setVisible(false);
                AboutProgram.this.dispose();
            }
        });
        pack();

        okButton.addActionListener((ActionEvent e) -> {
            AboutProgram.this.setVisible(false);
            AboutProgram.this.dispose();
        });
    }

}