from flask import Flask, render_template, make_response,Blueprint,redirect

import pdfkit
from utilities.db import Cart_Query
pdf = Blueprint('pdf', __name__, static_folder='static', static_url_path='/pdf', template_folder='templates')



@pdf.route('/pdf/<OrderID>') #'/<orderID>'
def pdf_template(OrderID): #instead, will get orderID and in pdf_template.html portray the relevant info
    q = Cart_Query.Cart_Query()
    productInOrder = q.getProductsInOrder(OrderID)
    TotalPrice = q.getTotalOrderPrice(OrderID)
    Comment =q.getComment(OrderID)
    rendered = render_template('pdf.html',OrderID=OrderID,productInOrder=productInOrder,TotalPrice=TotalPrice,Comment=Comment) #orderID = orderID
    css = '/Users/USER/PycharmProjects/web-g15/pages/pdf/static/css/pdf.css'
    wkhtmltopdf_options = {
        'enable-local-file-access': None
    } #allowed connection to css for some reason
    path_wkhtmltopdf = r'C:\Program Files\wkhtmltopdf\bin\wkhtmltopdf.exe'
    config = pdfkit.configuration(wkhtmltopdf=path_wkhtmltopdf)

    pdf = pdfkit.from_string(rendered, False, css=css, configuration = config, options=wkhtmltopdf_options)
    response = make_response(pdf)
    response.headers['Content-Type'] = 'application/pdf'
    response.headers['Content-Disposition']= 'attachment' #attachment downloads it
    return response
    #return redirect('homepage')

