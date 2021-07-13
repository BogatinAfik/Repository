from utilities.db import db_manager
from datetime import datetime

class Cart_Query:
    def __init__(self):
        self.db = db_manager.dbManager

    def getProducts(self, SupplierID):
        query = "SELECT * FROM products join units on products.Unit = units.UnitID where products.SupplierID = '%s'" %SupplierID
        ans = self.db.fetch(query=query)
        return ans;

    def getLastOrderID(self):
        query = "SELECT OrderID FROM orders"
        ans = self.db.fetch(query=query)
        maxOrderID = ans[-1][0]
        return maxOrderID

    def createNewOrder(self, OrderID, SupplierID, employeeID):
        query = "INSERT INTO orders (OrderID, OrderDT, SupplierID, employeeID, TotalPrice, Approved, Comment) VALUES ('%s','%s','%s','%s','%s','%s', '%s');" % (OrderID, datetime.today(), SupplierID, employeeID, 0, 0, '')
        self.db.commit(query = query)

    def createNewProductInOrder(self, ProductID, SupplierID, OrderID, Quantity):
        query = "INSERT INTO productsinorder (ProductID, SupplierID, OrderID, Quantity, TotalPrice)  VALUES ('%s','%s','%s','%s','%s');" % (ProductID, SupplierID, OrderID, Quantity, 0)
        self.db.commit(query=query)

    def getProductsInOrder(self, OrderID):
        current = OrderID
        query = "SELECT p1.OrderID, p1.ProductID, p1.TotalPrice, p1.Quantity, p2.ProductName, p2.Price, units.Type FROM productsinorder as p1 join products as p2 ON (p1.ProductID = p2.ProductID) join units ON (p2.Unit= units.UnitID) Where p1.OrderID = '%s'" %current
        ans = self.db.fetch(query=query)
        return ans;

    def getTotalOrderPrice(self, OrderID):
        current = OrderID
        query = "Select TotalPrice from orders where orders.OrderID = '%s'" %current
        ans = self.db.fetch(query=query)
        return ans[-1][0];

    def approveOrder(self, OrderID, Comment):
        current = OrderID
        query = "Update orders set Approved = '1', Comment= '%s' where orders.OrderID = '%s' " %(Comment, current)
        self.db.commit(query=query)

    def cancelOrder(self, OrderID):
        current = OrderID
        query1 = "Delete from productsinorder where productsinorder.OrderID = '%s'" % current
        self.db.commit(query=query1)
        query2 = "Delete From orders where orders.OrderID = '%s' " % current
        self.db.commit(query=query2)

    def getComment(self,OrderID):
        current = OrderID
        query = "Select Comment from orders where orders.OrderID = '%s'" % current
        ans = self.db.fetch(query=query)
        return ans[-1][0];
