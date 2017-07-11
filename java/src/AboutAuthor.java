import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

public class AboutAuthor extends JFrame {

    private JPanel panel;
    private JButton okButton;

    AboutAuthor() {
        setTitle("Об авторе");
        setContentPane(panel);
        setDefaultCloseOperation(WindowConstants.DO_NOTHING_ON_CLOSE);
        addWindowListener(new WindowAdapter() {
            @Override
            public void windowClosing(WindowEvent evt) {
                AboutAuthor.this.setVisible(false);
                AboutAuthor.this.dispose();
            }
        });
        pack();

        okButton.addActionListener((ActionEvent e) -> {
            AboutAuthor.this.setVisible(false);
            AboutAuthor.this.dispose();
        });
    }

}
