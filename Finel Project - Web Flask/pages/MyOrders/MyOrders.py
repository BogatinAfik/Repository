from flask import Blueprint, render_template,session

# notification blueprint definition
#from utilities.db import MyOrders_Query

MyOrders = Blueprint('MyOrders', __name__, static_folder='static', static_url_path='/MyOrders', template_folder='templates')


# Routes
@MyOrders.route('/MyOrders')
def index():

    #q = MyOrders_Query.MyOrders_Query()
    #MyOrders = q.getMyOrders()
    # , MyOrders=MyOrders להוסיף לסוגריים למטה
    if session['login']:
        return render_template('MyOrders.html')
    else:
        error = 'נא להתחבר כמשתמש למערכת'
        return render_template('pdf.html',error=error)