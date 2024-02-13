public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode target = new();// target memory allocation
        var iter1 = list1;var iter2 = list2;var iterTarget = target;//variables declaration
        while (iter1 != null && iter2 != null)//iterating both the not nullable list 
        {
            if (iter1.val <= iter2.val)//checking list2 greater than list1
            {
                iterTarget.next = iter1;
                iter1 = iter1.next;}
            else
            {
                iterTarget.next = iter2;iter2 = iter2.next;}
            iterTarget = iterTarget.next;
        }
        if (iter1 != null){iterTarget.next = iter1;}//checking 1st list is vaccant or not 
        if (iter2 != null){iterTarget.next = iter2;}//checking 2nd list is vaccan or not
        return target.next;//printing next target 
    }
}
