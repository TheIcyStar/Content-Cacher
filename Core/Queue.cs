using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content_Cacher.Core {
	class QueueObject
	{
		string title;
		string url;

		public QueueObject(string newtitle, string newURL)
		{
			title = newtitle;
			url = newURL;
		}
		//and maybe its info object as well? to early to tell. Oh well. 
	}
	class DownloadQueue {

		public delegate void DownloadQueueEventHandler(object source, EventArgs args);
		public event DownloadQueueEventHandler AddedToQueue;
		public event DownloadQueueEventHandler QueueChange;

		public Queue<QueueObject> ToDownloadQueue = new Queue<QueueObject>();

		public void AddToQueue(string title, string URL) {
			QueueObject newObj = new QueueObject(title, URL);
			ToDownloadQueue.Enqueue(newObj);

			//Console.WriteLine("DownloadQueue.AddToQueue(): adding obj to queue");

			OnAddedToQueue();
			OnQueueChange();
		}

		//makes an array from the queue and returns the index
		public QueueObject ExtractFromQueue(int index) {
			QueueObject[] QueueArray = new QueueObject[ToDownloadQueue.Count];
			ToDownloadQueue.CopyTo(QueueArray, 0);
			return QueueArray[index];
		}

		/// <summary>
		/// Swaps two items in the queue
		/// </summary>
		/// <param name="index">QueueObject to be swapped with target</param>
		/// <param name="target">QueueObject to be swapped with index</param>
		public void SwapInQueue(int index, int target) {
			QueueObject[] QueueArray = new QueueObject[ToDownloadQueue.Count];
			ToDownloadQueue.CopyTo(QueueArray, 0);

			QueueObject temp = QueueArray[index];
			QueueArray[index] = QueueArray[target];
			QueueArray[target] = temp;

			//remake queue
			OnQueueChange();
			ToDownloadQueue = new Queue<QueueObject>(QueueArray); //could this make a problem?
		}

		protected virtual void OnAddedToQueue() { //called when only one thing is added to the queue
			if (AddedToQueue != null) {
				AddedToQueue(this, EventArgs.Empty);
			}
		}

		protected virtual void OnQueueChange() { //called whenever something is changed in a queue
			if (QueueChange != null) {
				QueueChange(this, EventArgs.Empty);
			}
		}
	}
}
