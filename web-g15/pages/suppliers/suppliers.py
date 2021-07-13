from flask import Blueprint, render_template,session

# suppliers blueprint definition
from utilities.db import Cart_Query

suppliers = Blueprint('suppliers', __name__, static_folder='static', static_url_path='/suppliers', template_folder='templates')


# Routes
@suppliers.route('/suppliers')
def index():
    #q = Cart_Query.Cart_Query()
    #dishes = q.getDishes()
    #, dishes=dishes להוסיף בריטארן בסוגריים
    if session['login']:
        return render_template('suppliers.html')
    else:
        error = 'נא להתחבר כמשתמש למערכת'
        return render_template('pdf.html',error=error)