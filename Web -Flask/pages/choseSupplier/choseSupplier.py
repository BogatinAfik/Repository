from flask import Blueprint, render_template,session
from utilities.db import suppliers_Query
# notification blueprint definition
choseSupplier = Blueprint('choseSupplier', __name__, static_folder='static', static_url_path='/choseSupplier', template_folder='templates')


# Routes
@choseSupplier.route('/choseSupplier')
def index():
    if session['login']:
        q= suppliers_Query.suppliers_Query()
        suppliers = q.getSuppliers()

        return render_template('choseSupplier.html',suppliers=suppliers)
    else:
        error = 'נא להתחבר כמשתמש למערכת'
        return render_template('pdf.html',error=error)