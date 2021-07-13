import java.util.Vector;
public class PriorityQueue <T extends Comparable> {

	protected Vector<T> priorityQueue;

	public PriorityQueue() {
		priorityQueue = new Vector<T>();
	}

	public synchronized Vector <T> getPriorityQueue() { 
		return priorityQueue;
	}

	public synchronized void insert(T item) {
		priorityQueue.add(item);
		sortQueue();
		notifyAll(); 
	}

	//sorts queue by condition level
	private void sortQueue() {
		for (int i = 0; i<priorityQueue.size()-1; i++) {
			for (int j = 0; j < priorityQueue.size()-i-1; j++) {
				if (priorityQueue.elementAt(j) != null && priorityQueue.elementAt(j+1) != null) {	
					if (priorityQueue.elementAt(j).compareTo(priorityQueue.elementAt(j+1)) < 0) {
						swap(j);
					}
				}
			}
		}

	}

	//swaps two cells in a vector
	public void swap (int j) {
		T temp = priorityQueue.elementAt(j);
		priorityQueue.setElementAt(priorityQueue.elementAt(j+1), j);
		priorityQueue.setElementAt(temp ,j+1);
	}


	public synchronized T extract() {
		while (priorityQueue.isEmpty())
			try {
				wait();
			} catch (InterruptedException e) {

			}
		T item = priorityQueue.elementAt(0);
		priorityQueue.remove(item);
		return item;    
	}
}
