from flask import Blueprint, render_template, redirect, url_for,session

# homepage blueprint definition
homepage = Blueprint('homepage', __name__, static_folder='static', static_url_path='/pages/homepage', template_folder='templates')


# Routes



@homepage.route('/homepage')
@homepage.route('/home')
def redirect_homepage():
    if session['login']:
        return render_template('homepage.html')
    else:
        error = 'נא להתחבר כמשתמש למערכת'
        return render_template('login.html',error=error)