public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: The Enqueue function shall add an item (which contains both data and priority) to the back of the queue.

        // Expected Result: Add 3 elements to the queue
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Leissure", 2);
        priorityQueue.Enqueue("Study", 4);
        priorityQueue.Enqueue("Work", 7);
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: All good

        Console.WriteLine("---------");

        // Test 2
        // Scenario: The Dequeue function shall remove the item with the highest priority and return its value.
        // Expected Result: Dequeue should return the highest number
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("Homework", 4);
        priorityQueue.Enqueue("Eat Lunch", 4);
        priorityQueue.Enqueue("Doctor appointment", 3);

        var lastValueTest2 = priorityQueue.Dequeue();
        Console.WriteLine($"Dequeued value: {lastValueTest2}");
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: Dequeue wasn't removing the element from the list

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
        // Test 3
        // Scenario: If there are more than one item with the highest priority, 
        //           then the item closest to the front of the queue will be removed and its value returned.
        // Expected Result: Dequeue should return the first appearance of the highest number
        Console.WriteLine("Test 3");
        priorityQueue.Enqueue("Talk to mom", 4);
        Console.WriteLine(priorityQueue);
        var lastValueTest3 = priorityQueue.Dequeue();
        Console.WriteLine($"Dequeued value: {lastValueTest3}");
        Console.WriteLine(priorityQueue);   

        // Defect(s) Found: Dequeue removing wrong instance of high priority

        Console.WriteLine("---------");

        // Test 4
        // Scenario: If the queue is empty, then an error message will be displayed.
        // Expected Result: Error message should display
        Console.WriteLine("Test 4");
        var priorityQueue2 = new PriorityQueue();
        // Console.WriteLine(priorityQueue);
        priorityQueue2.Dequeue();
        
        // Defect(s) Found: Working fine
    }
}