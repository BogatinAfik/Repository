from flask import Flask, request, redirect, url_for, render_template, session

###### App setup
app = Flask(__name__)
app.config.from_pyfile('settings.py')
app.secret_key = '1234567'

###### Pages
## Homepage
from pages.homepage.homepage import homepage

app.register_blueprint(homepage)

## About
from pages.notification.notification import notification

app.register_blueprint(notification)


from pages.pdf.pdf import pdf

app.register_blueprint(pdf)

## suppliers
from pages.suppliers.suppliers import suppliers

app.register_blueprint(suppliers)

## Page error handlers
from pages.page_error_handlers.page_error_handlers import page_error_handlers

app.register_blueprint(page_error_handlers)

###### Components

from components.header.header import header

app.register_blueprint(header)

from components.footer.footer import footer

app.register_blueprint(footer)

from pages.contact.contact import contact

app.register_blueprint(contact)

from pages.cart.cart import cart

app.register_blueprint(cart)

from pages.login.login import login

app.register_blueprint(login)

from pages.registration.registration import registration

app.register_blueprint(registration)

from pages.MyOrders.MyOrders import MyOrders

app.register_blueprint(MyOrders)


from pages.choseSupplier.choseSupplier import choseSupplier

app.register_blueprint(choseSupplier)

from pages.createOrder.createOrder import createOrder

app.register_blueprint(createOrder)

from pages.checkout.checkout import checkout

app.register_blueprint(checkout)

from pages.cart_error.cart_error import cart_error

app.register_blueprint(cart_error)

from pages.update_user.update_user import update_user

app.register_blueprint(update_user)





