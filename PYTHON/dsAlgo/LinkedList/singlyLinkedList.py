class node:
    '''
    an object for storing a single node in a linked list

    attributes:
        data: data stored in node
        next: reference to next node in the linked list [self referential]
    '''

    def __init__(self, data, next=None) ->None:
        self.data=data
        self.next=next
    
    def __repr__(self) -> str:
        return "<Node data: {}>".format(self.data)

class linkedList:
    '''
    Linear Data Structure that stores values in nodes

    The list maintains the reference to the first node, also called head. Each node points to the next node in the list.

    Attributes:
        head: the head if the list
    '''
    def __init__(self) -> None:
        self.head=None
        
    
    def is_empty(self):
        '''Determines if the linked list is empty
            takes O(1) time
        '''
        return self.head is None

    def size(self):
        '''
        Determines the size of linked list
        takes O(n) time
        '''
        count=0
        current=self.head
        while current:
            count+=1
            current=current.next
        return count
    def contains(self, key):
        current=self.head
        while(current):
            if(current.data==key):
                return True
            current=current.next
        return False

    def readat(self, index):
        '''
        read at any index
        display out of bound message if index not present
        O(n) time
        '''
        if(self.is_empty()):
            return "List is empty"
        if(self.size()<=index):
            return "Index out of bounds for read operation"
        if(index==0):
                return self.head.data
        position=0
        current=self.head
        while(current):
            if(position==index):
                return current.data
            position+=1
            current=current.next


    def add(self, data):

        '''
        adds a new node at the beginning of the linked list
        takes O(1) time
        '''
        new_node=node(data)
        new_node.next=self.head
        self.head=new_node

    def search(self, key):
        '''
        search for the first node containing data that matches the key 
        return the node or None if not found

        Takes O(n) time
        '''
        current=self.head
        while current:
            if current.data==key:
                return current
            current=current.next
        return None
    

    def insert(self, data, index):
        '''
        Zero based index
        if index 0 -> adding new head
        if index > 0, insert

        '''
        if(index == 0):
            self.add(data)
            return
        if(index>self.size()):
            print('Supplied index out of bounds of the list.')
            return
        current=self.head
        if(index>0):
            position=1
            while position<index and position<self.size(): # we need to ensure we are still able to add a node if supplied index is more than the size of the linked list
                current=current.next
                position+=1
            new_node=node(data)
            new_node.next =current.next
            current.next=new_node

    def delete(self, key):
        '''
        deletes the first existing nodet that matches
        takes O(n) time
        return None if the key doesn't exists

        '''
        current=self.head
        found=False
        previous=None

        while current and not found:
            if current.data==key and current is self.head:
                found=True
                self.head=current.next
            elif current.data==key:
                found=True
                previous.next=current.next

            else:
                previous=current
                current=current.next                
        return current

    def deleteat(self, index):
        '''
        deletes an existing node at a given index
        index is zero based
        if the index doesn't exist prints a message
        linear time
        '''
        if(self.is_empty()):
            return 'List is empty'
        if(index >=self.size()):
            return 'Index is our of bounds of the list'
        previous=None
        current=self.head
        position=0
        if(index==0):
            self.head=current.next
            return current
        while current and position<index:
            previous=current
            current=current.next
            position+=1
        
        previous.next=current.next
        return current

    def __repr__(self) -> str:
        '''
        returns a string representation of the list
        takes O(n) time
        '''

        nodes=[]
        current =self.head

        while current:
            if current is self.head:
                nodes.append('[Head: {}]'.format(current.data))
            elif current.next is None:
                nodes.append('[Tail: {}]'.format(current.data))
            else:
                nodes.append('[{}]'.format(current.data))
            current=current.next
        return ' -> '.join(nodes)


