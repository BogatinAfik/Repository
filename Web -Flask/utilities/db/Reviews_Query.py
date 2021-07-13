from utilities.db import db_manager

class Reviews_Query:
    def __init__(self):
        self.db = db_manager.dbManager

    def getReviews(self):
        query = "Select R.reviewID, R.content, C.first_name, C.last_name, C.customerID, R.image from Reviews as R join customers as C on (R.customerID = C.customerID)"
        ans = self.db.fetch(query=query)
        return ans;
