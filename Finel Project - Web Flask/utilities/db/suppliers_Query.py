from utilities.db import db_manager
from datetime import datetime

class suppliers_Query:
    def __init__(self):
        self.db = db_manager.dbManager

    def getSuppliers(self):
        query = "SELECT * FROM suppliers"
        ans = self.db.fetch(query=query)
        return ans;

    def getLastOrderID(self):
        query = "SELECT orderID FROM orders"
        ans = self.db.fetch(query=query)
        maxOrderID = ans[-1][0]
        return maxOrderID

    def createNewOrder(self, orderID, User):
        query = "INSERT INTO orders (orderID, order_date, total_price, customerID, approved) VALUES ('%s','%s','%s','%s','%s');" % (orderID, datetime.today(), 0, User, 0)
        self.db.commit(query = query)

    def createNewDishInOrder(self, orderID, dishID, quantity):
        query = "INSERT INTO dishes_in_order (orderID, dishID, quantity, total_price)  VALUES ('%s','%s','%s','%s');" % (orderID, dishID, quantity, 0)
        self.db.commit(query=query)

    def getDishesInOrder(self, orderID):
        current = orderID
        query = "SELECT d1.orderID, d1.dishID, d1.total_price, d1.quantity, d2.dish_name, d2.image, d2.price FROM dishes_in_order as d1 join dishes as d2 ON (d1.dishID = d2.dishID) Where d1.orderID = '%s'" %current
        ans = self.db.fetch(query=query)
        return ans;

    def getTotalOrderPrice(self, orderID):
        current = orderID
        query = "Select total_price from orders where orders.orderID = '%s'" %current
        ans = self.db.fetch(query=query)
        return ans[-1][0];

    def approveOrder(self, orderID):
        current = orderID
        query = "Update orders set approved = '1' where orders.orderID = '%s' " %current
        self.db.commit(query=query)

    def cancelOrder(self, orderID):
        current = orderID
        query1 = "Delete from dishes_in_order where dishes_in_order.orderID = '%s'" % current
        self.db.commit(query=query1)
        query2 = "Delete From Orders where orders.orderID = '%s' " % current
        self.db.commit(query=query2)