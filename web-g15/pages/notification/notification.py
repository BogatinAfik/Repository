from flask import Blueprint, render_template,session

# notification blueprint definition
notification = Blueprint('notification', __name__, static_folder='static', static_url_path='/notification', template_folder='templates')


# Routes
@notification.route('/notification')
def index():
    if session['login']:
        return render_template('notification.html')
    else:
        error = 'נא להתחבר כמשתמש למערכת'
        return render_template('pdf.html',error=error)