from flask import Blueprint, render_template, session, request

# about blueprint definition
from utilities.db import Customer_Query

update_user = Blueprint('update_user', __name__, static_folder='static',static_url_path='/update_user', template_folder='templates')


# Routes
@update_user.route('/update_user')
def index():
    q = Customer_Query.Customer_Query()
    customerInfo = q.getCustomerInfo(session['userID'])
    return render_template('update_user.html', customerInfo= customerInfo)


@update_user.route('/update_user', methods=['GET', 'POST'])
def update():
    if request.method == 'POST':
        q = Customer_Query.Customer_Query()
        customerID = session['userID']
        first_name = request.form['first_name']
        last_name = request.form['last_name']
        phone = request.form['phone']
        email = request.form['email']
        psw = request.form['psw']
        q.updateCustomerInfo(customerID, first_name, last_name, phone, email, psw)
        success = 'העדכון בוצע בהצלחה!'
        customerInfo = q.getCustomerInfo(session['userID'])

        return render_template('update_user.html', customerInfo=customerInfo, success=success)