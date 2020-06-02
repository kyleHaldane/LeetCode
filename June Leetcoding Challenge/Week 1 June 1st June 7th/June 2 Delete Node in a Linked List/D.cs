public class Solution {
    public void DeleteNode(ListNode node) {
        node.val = node.next.val;
        
        if(node.next.next == null)
            node.next = null;
        
        if(node.next != null)
            DeleteNode(node.next);
    }
}