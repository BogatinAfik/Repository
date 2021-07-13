import java.io.BufferedReader;
import java.io.FileReader;
import java.util.Vector;
import java.sql.*;
public class EmergencyRoom {

	protected PriorityQueue <Patient> senDocLine; //line for senior doc
	protected BoundedQueue <Patient> junDocLine; //line for junior doc
	protected UnboundedQueue <Patient> pharmLine; //line for pharmacist
	protected UnboundedQueue <Patient> nurseLine; //line waiting for the nurses
	protected UnboundedQueue <Patient> managerData; //updates for manager
	protected int numOfNurses; //gets from GUI (user input)
	protected int closingTime; //gets from GUI (user input)
	protected Object key; //key that syncs workers and manager together
	protected Vector <Patient> pTracker; //keeps track of patients going in and out of the ER
	
	
	public EmergencyRoom(String patients, int numOfNurses, int closingTime) {
		senDocLine = new PriorityQueue <Patient>();
		junDocLine = new BoundedQueue <Patient>(8);
		pharmLine = new UnboundedQueue <Patient>();
		nurseLine = new UnboundedQueue <Patient>();
		managerData = new UnboundedQueue <Patient>();
		pTracker = new Vector <Patient>();
		this.numOfNurses = numOfNurses;
		this.closingTime = closingTime;
		this.key = new Object();
		startManager();
		startWorkDay();
		readNurseLine(patients);
	}

	//starts manager thread
	private void startManager() {
		Manager manager = new Manager(closingTime, senDocLine, junDocLine, pharmLine, nurseLine, managerData, key, numOfNurses, pTracker); 
		Thread boss = new Thread(manager);
		boss.start();
	}

	//reads patient text file
	private void readNurseLine(String patients) {
		try {
			FileReader reader = new FileReader(patients);
			BufferedReader inFile = new BufferedReader(reader);
			String line = inFile.readLine();
			while ((line = inFile.readLine()) != null) { 
				String[] data = line.split("\t");
				Patient p = newPatient(data, 0, 1, 2, 3, 4, 5, 6);
				Thread patient = new Thread(p);
				patient.start();
			}
			inFile.close();
			reader.close();
		} catch (Exception exception) {
			System.out.println(exception);
		}
	}

	//creates patients according to text file
	private Patient newPatient(String[] data, int firstNameCell, int lastNameCell, int ageCell,
			int heightCell, int weightCell, int idCell, int arrivalTimeCell) {
		String firstName = data[firstNameCell];
		String lastName = data[lastNameCell];
		int age = Integer.parseInt(data[ageCell]);
		int height = Integer.parseInt(data[heightCell]);
		int weight = Integer.parseInt(data[weightCell]);
		int id = Integer.parseInt(data[idCell]);
		int arrivalTime = Integer.parseInt(data[arrivalTimeCell]);
		return new Patient(firstName, lastName, age, height, weight, id, arrivalTime, nurseLine, pTracker);
	}

	//starts all workers
	public void startWorkDay() {
		startNurses();
		startDoctors();
		startPharmacists();

	}

	//starts pharmacist threads
	private void startPharmacists() {
		Pharmacist[] pharms = new Pharmacist[2];
		for (int i = 0; i < pharms.length; i++) {
			pharms[i] = new Pharmacist (senDocLine, junDocLine, pharmLine,nurseLine, managerData, key, pTracker);
			Thread pharmOne = new Thread(pharms[i]);
			pharmOne.start();
		}

	}

	//starts doctor threads
	public  void startDoctors() {
		JuniorDoctor[] zootarim = new JuniorDoctor[3]; 
		for (int i = 0 ; i < zootarim.length; i++) {
			zootarim[i] = new JuniorDoctor(senDocLine, junDocLine, pharmLine, nurseLine, managerData, key, pTracker);
			Thread junior = new Thread(zootarim[i]);
			junior.start();
		}	

		SeniorDoctor senDoc = new SeniorDoctor(senDocLine, junDocLine, pharmLine, nurseLine, managerData, key, pTracker);
		Thread senior = new Thread(senDoc);
		senior.start();

	}


	//starts nurse threads
	public void startNurses() {
		Nurse[] achayot = new Nurse[numOfNurses]; 
		for (int i=0; i < achayot.length; i++) {
			achayot [i] = new Nurse(senDocLine, junDocLine, pharmLine, nurseLine, managerData, key, pTracker);
			Thread achot = new Thread(achayot[i]);
			achot.start();
		}
	}
	
}