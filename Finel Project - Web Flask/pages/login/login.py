from flask import Blueprint, render_template, request, redirect, url_for, session
from utilities.db import Customer_Query
# login blueprint definition
login = Blueprint('login', __name__, static_folder='static', static_url_path='/login', template_folder='templates')



# Routes
@login.route('/')
@login.route('/login')
def index2():
    session['login'] = False
    return render_template('login.html')


@login.route('/loginConected')
def index():

    return render_template('login.html')


@login.route('/login_user', methods=['GET', 'POST'])
def check_if_exist():
    q = Customer_Query.Customer_Query()
    error = ""
    session['login'] = False
    if request.method == 'GET':
        return render_template('login.html')
    if request.method == 'POST':
        users = q.get_employees()
        for u in users:
            if request.form['email'] == u.Email:
                if request.form['psw'] == u.Password:
                    session['login'] = True
                    session['name'] = u.Name

                    session['email'] = u.Email
                    session['userID'] = u.employeeID
                    return render_template('homepage.html')
                else:
                    error = 'הסיסמה שגויה'
                    return render_template('login.html', error=error)

    error = 'האימייל לא קיים במערכת'
    return render_template('login.html', error=error)


@login.route('/logout_user', methods=['GET', 'POST'])
def logout():
    session['login'] = False
    session['userID'] = ''
    session['name'] = ''
    session['last_name'] = ''
    session['email'] = ''
    return render_template('login.html')