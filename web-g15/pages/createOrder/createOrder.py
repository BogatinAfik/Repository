from flask import Blueprint, render_template,session

# notification blueprint definition
createOrder = Blueprint('createOrder', __name__, static_folder='static', static_url_path='/createOrder', template_folder='templates')


# Routes
@createOrder.route('/createOrder')
def index():
    if session['login']:
        return render_template('createOrder.html')
    else:
        error = 'נא להתחבר כמשתמש למערכת'
        return render_template('pdf.html',error=error)