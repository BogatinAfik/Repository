from flask import Blueprint, render_template

# checkout blueprint definition
from utilities.db import Cart_Query

checkout = Blueprint('checkout', __name__, static_folder='static', static_url_path='/checkout', template_folder='templates')


# Routes
@checkout.route('/checkout/<OrderID>',  methods = ['GET', 'POST'])
def index(OrderID):
    q = Cart_Query.Cart_Query()
    productInOrder = q.getProductsInOrder(OrderID)
    TotalPrice = q.getTotalOrderPrice(OrderID)
    return render_template('checkout.html', productInOrder=productInOrder, TotalPrice=TotalPrice)


