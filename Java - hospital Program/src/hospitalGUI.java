import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.SwingConstants;

public class hospitalGUI extends JFrame {

	/**
	 * 
	 */
	
	private JPanel contentPane;
	private JTextField textField;
	private JTextField textField_1;
	private JLabel lblInvalidNumberOf;
	private JLabel lblInvalidClosingTime;

	
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					hospitalGUI frame = new hospitalGUI();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	public hospitalGUI() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);

		textField = new JTextField();
		textField.setHorizontalAlignment(SwingConstants.LEFT);
		textField.setText("0");
		textField.setBounds(267, 77, 146, 26);
		contentPane.add(textField);
		textField.setColumns(10);

		textField_1 = new JTextField();
		textField_1.setText("8");
		textField_1.setBounds(267, 144, 146, 26);
		contentPane.add(textField_1);
		textField_1.setColumns(10);

		JLabel lblNumberOfNurses = new JLabel("Number of Nurses");
		lblNumberOfNurses.setBounds(53, 80, 177, 20);
		contentPane.add(lblNumberOfNurses);

		JLabel lblErClosingTime = new JLabel("ER Closing Time");
		lblErClosingTime.setBounds(53, 147, 146, 20);
		contentPane.add(lblErClosingTime);

		JButton btnStart = new JButton("Start");
		btnStart.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
		
				int numOfNurses = Integer.parseInt(textField.getText());
					if (numOfNurses > 4 || numOfNurses < 0) {
						lblInvalidNumberOf.setVisible(true);
					}

					int closingTime = Integer.parseInt(textField_1.getText());

					if (closingTime > 24 || closingTime < 0) {
						lblInvalidClosingTime.setVisible(true);
					}
				//starts emergency room
				EmergencyRoom e = new EmergencyRoom("patients.txt", numOfNurses, closingTime); 


			}
		});
		btnStart.setBounds(100, 199, 115, 29);
		contentPane.add(btnStart);

		JButton btnExit = new JButton("Exit");
		btnExit.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				System.exit(0);
			}
		});
		btnExit.setBounds(230, 199, 115, 29);
		contentPane.add(btnExit);

		JLabel lblFatmaEmergencyRoom = new JLabel("FATMA Emergency Room");
		lblFatmaEmergencyRoom.setBounds(131, 16, 214, 20);
		contentPane.add(lblFatmaEmergencyRoom);
		
		 lblInvalidNumberOf = new JLabel("Invalid Number of Nurses!!");
		lblInvalidNumberOf.setBounds(131, 116, 208, 20);
		lblInvalidNumberOf.setVisible(false);
		contentPane.add(lblInvalidNumberOf);
		
		lblInvalidClosingTime = new JLabel("Invalid Closing Time!!");
		lblInvalidClosingTime.setBounds(141, 174, 177, 20);
		lblInvalidClosingTime.setVisible(false);
		contentPane.add(lblInvalidClosingTime);
	}
}
