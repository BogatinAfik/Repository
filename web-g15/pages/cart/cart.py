from flask import Blueprint, render_template, request, redirect, url_for, session

# cart blueprint definition
from utilities.db import Cart_Query

cart = Blueprint('cart', __name__, static_folder='static', static_url_path='/cart', template_folder='templates')


# Routes
@cart.route('/cart', methods=['GET', 'POST'])
def index():
    SupplierID = request.form['SupplierID']
    q = Cart_Query.Cart_Query()
    products = q.getProducts(SupplierID)
    return render_template('cart.html', products=products)


@cart.route('/createOrder', methods=['GET', 'POST'])
def createOrder():
    q = Cart_Query.Cart_Query()
    checkInput = 0
    for temp in request.form:
        checkInput = checkInput + int(request.form[temp])
    if checkInput != 0:
        newOrderID = q.getLastOrderID() + 1
        if request.method == "POST":
            if session['login']:
                employeeID = session['userID']
                SupplierID = request.form['SupplierID']
                q.createNewOrder(newOrderID, SupplierID, employeeID)
                for temp in request.form:
                    if request.form[temp] != '0' and temp != 'SupplierID':
                        q.createNewProductInOrder(temp, SupplierID, newOrderID, request.form[temp])
                return redirect(url_for('checkout.index', OrderID=newOrderID))
            else:
                error = 'נא להתחבר כמשתמש על מנת לבצע הזמנה'
                return render_template('cart_error.html', error=error)
    else:
        error = 'לא נבחרו מוצרים לרכישה'
        return render_template('cart_error.html', error=error)

@cart.route('/sendOrder', methods=['GET', 'POST'])
def sendOrder():
    q = Cart_Query.Cart_Query()
    if request.method == "POST":
        OrderID = request.form['orderID']
        Comment = request.form['Comment']
        q.approveOrder(OrderID,Comment)
    return redirect(url_for('pdf.pdf_template', OrderID=OrderID))



@cart.route('/cancelOrder', methods=['GET', 'POST'])
def cancelOrder():
    q = Cart_Query.Cart_Query()
    if request.method == "POST":
        orderID = request.form['orderID']
        q.cancelOrder(orderID)
    return redirect('choseSupplier')