class Solution {
public:
    ListNode* mergeTwoLists(ListNode* list1, ListNode* list2) {
        //new_solution
        ListNode* t1 = list1;ListNode* t2 = list2;ListNode* dummy = new ListNode(-1);ListNode* temp = dummy; 
        while (t1 != nullptr && t2 != nullptr) {
            if (t1->val < t2->val) {
                temp->next = t1;
                t1 = t1->next;
            } else {
                temp->next = t2;
                t2 = t2->next;
            }
            temp = temp->next; 
        }
        temp->next = (t1 != nullptr) ? t1 : t2;
        return dummy->next;}};
