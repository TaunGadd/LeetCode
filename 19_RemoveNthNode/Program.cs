var solution = new Solution();
var node5 = new ListNode(5);
var node4 = new ListNode(4, node5);
var node3 = new ListNode(3, node4);
var node2 = new ListNode(2, node3);
var node1 = new ListNode(1, node2);

var list = solution.RemoveNthFromEnd(node1, 5);

while (list != null)
{
    Console.WriteLine(list.val);
    list = list.next;
}


public class ListNode
{
     public int val;
     public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
 }

public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        // Always store node that is n-1 and n+1 away from the current.
        // When I reach end, connect the two nodes

        if (head.next == null) return null;
        if (head.next.next == null && n == 1)
        {
            head.next = null;
            return head;
        }

        var currentNode = head;

        for (int i = 0; i < n; i++)
        {
            currentNode = currentNode.next;
        }

        if (currentNode == null)
        {
            return head.next;
        }
        else
        {
            currentNode = currentNode.next;
        }

        var left = head;
        var right = head.next.next;

        while (currentNode != null)
        {
            left = left.next;
            right = right.next;
            currentNode = currentNode.next;
        }

        left.next = right;

        return head;
    }
}