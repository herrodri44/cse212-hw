/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
public class CustomerService {
    public static void Run() {
        // Example code to see what's in the customer service queue:
        // var cs = new CustomerService(10);
        // Console.WriteLine(cs);

        // Test Cases

        // Test 1
        // Scenario: Create a new CustomerService with a negative number
        // Expected Result: Should create a queue size 10 by default
        Console.WriteLine("Test 1");
        CustomerService cs = new CustomerService(-2);

        System.Diagnostics.Trace.Assert(cs._maxSize == 10, "The max size should be 10 in this scenario");


        // Defect(s) Found: No problem

        Console.WriteLine("=================");

        // Test 2
        // Scenario: Run the AddNewCustomer
        // Expected Result: the queue should be of length 1 
        Console.WriteLine("Test 2");
        CustomerService test2CustomerService = new CustomerService(5);
        test2CustomerService.AddNewCustomer();

        System.Diagnostics.Trace.Assert(test2CustomerService._queue.Count == 1, "The queue should have 1 customer");
        // Defect(s) Found: No problem

        Console.WriteLine("=================");

        // Add more Test Cases As Needed Below
        // Test 3
        // Scenario: If the queue is full when trying to add a customer, then an error message will be displayed.
        // Expected Result: Get an console error message, and queue should be 1
        Console.WriteLine("Test 3");
        CustomerService test3CustomerService = new CustomerService(1);
        test3CustomerService.AddNewCustomer();
        test3CustomerService.AddNewCustomer();

        System.Diagnostics.Trace.Assert(test3CustomerService._queue.Count == 1, "The queue should have 1 customer");
        // Defect(s) Found: Evaluating the max size was wrong, had to add >= to the expression.

        Console.WriteLine("=================");
        // Test 4
        // Scenario: The ServeCustomer function shall dequeue the next customer from the queue and display the details.
        // Expected Result: Queue should be of length 1, and should display customer details
        Console.WriteLine("Test 4");
        CustomerService test4CustomerService = new CustomerService(2);
        test4CustomerService.AddNewCustomer();
        test4CustomerService.AddNewCustomer();

        test4CustomerService.ServeCustomer();

        System.Diagnostics.Trace.Assert(test4CustomerService._queue.Count == 1, "The queue should have 1 customer");
        // Defect(s) Found: No problems

        Console.WriteLine("=================");
        // Test 5
        // Scenario: If the queue is empty when trying to serve a customer, then an error message will be displayed.
        // Expected Result: Program displayes an error message and doesn't crash.
        Console.WriteLine("Test 5");
        CustomerService test5CustomerService = new CustomerService(3);

        try
        {
            test5CustomerService.ServeCustomer();
        }
        catch (System.Exception)
        {
            Console.WriteLine("A message should have been displayed. Error not caught");
        }

        System.Diagnostics.Trace.Assert(test5CustomerService._queue.Count == 0, "The queue should have been 0");
        // Defect(s) Found: No validations. No error message was being displayed
    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

    public CustomerService(int maxSize) {
        if (maxSize <= 0)
            _maxSize = 10;
        else
            _maxSize = maxSize;
    }

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
    private class Customer {
        public Customer(string name, string accountId, string problem) {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

        public override string ToString() {
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// </summary>
    private void AddNewCustomer() {
        // Verify there is room in the service queue
        if (_queue.Count >= _maxSize) {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        Console.Write("Customer Name: ");
        var name = Console.ReadLine()!.Trim();
        Console.Write("Account Id: ");
        var accountId = Console.ReadLine()!.Trim();
        Console.Write("Problem: ");
        var problem = Console.ReadLine()!.Trim();

        // Create the customer object and add it to the queue
        var customer = new Customer(name, accountId, problem);
        _queue.Add(customer);
    }

    /// <summary>
    /// Dequeue the next customer and display the information.
    /// </summary>
    private void ServeCustomer() {
        // Verify there is something in the queue
        if (_queue.Count == 0) {
            Console.WriteLine("Queue is empty, try adding customers first");
            return;
        }

        _queue.RemoveAt(0);
        var customer = _queue[0];
        Console.WriteLine(customer);
    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString() {
        return $"[size={_queue.Count} max_size={_maxSize} => " + String.Join(", ", _queue) + "]";
    }
}