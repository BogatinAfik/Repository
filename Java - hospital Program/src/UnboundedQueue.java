import java.util.Vector;

public class UnboundedQueue <T>{
	protected Vector<T> unboundQueue;

	public UnboundedQueue() {
		unboundQueue = new Vector<T>();
	}
	
	public synchronized void insert(T item) {
		unboundQueue.add(item);
		notifyAll(); 
	}

	public synchronized T extract() {
		while (unboundQueue.isEmpty())
			try {
				wait();
			} catch (InterruptedException e) {

			}
		T item = unboundQueue.elementAt(0);
		unboundQueue.remove(item);
		return item;    
	}
	
	public synchronized Vector <T> getUnboundQueue() { 
		return unboundQueue;
	}

}
