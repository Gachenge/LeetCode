Console.WriteLine("Hello, World!");

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var carry = 0;
        var sum = 0;
        ListNode dummy = new ListNode();
        ListNode start = dummy;
        while (l1 != null || l2 != null)
        {
            int val1 = l1 != null ? l1.val : 0;
            int val2 = l2 != null ? l2.val : 0;

            sum = val1 + val2 + carry;
            carry = sum / 10;

            dummy.next = new ListNode(sum % 10);
            dummy = dummy.next;

            l1 = l1?.next;
            l2 = l2?.next;

        }
        if (carry > 0)
        {
            dummy.next = new ListNode(carry);
        }

        return start.next;
    }
}
