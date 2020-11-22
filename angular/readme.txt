
Application state => 
    data that showed - 
    stored in array and properties, 
    stored in components
    setting or getting data is state
    reflection of UI

DEsign logic
    HTML
    written in template
APp logic
    supply data to desgin logic
    written in components
    responed to event

Business logic
    written in service

Sepration of DOM manipulation logic from application logic,
sepration of HTML logic from app logic
sepration of business logic from app logic
code maintable => module is colleciton of components
SPA easier
routing and URL mainttaing

Building blocks
    component => 
        app data and event handlers 
        data like grid data saved in componen
    Templates
        design logic
    
    Data binding
        glue between component (app data + event handler) + Templates (design logic)

    modules
        collection of components
    
    services => business logic + REST API calls

    DEPENDENCY INJECTIONss
        LOAD SERVICES OBJECT Ainto components

    Driectives
        Direct dom manipulation code (not recommended)

    Installing Node js/ VS code / Angular CLI / ng new / ng serve
    install angular cli => npm install @angular/cli -g 
    ng new MyApp  --style = scss (sass)  --routinh --skip-install

    ng serve --open --port=5200   (4200 is default port)
    change content press save cotnet auto updated

    bootstrap install
        npm install jquery --save  (save will save the package name in DEPENDENCY section)
        npm install popper.js --save
        npm install bootstrap --save
        npm install font-awesome --save 

        ctrl + c twice suspend previous comment and accomnade for new command
        like ng server --open 


        What is component
            component class contains programming logic of the application
            component class contains application data + event handler methods
            component class is responsible to supply data to the template 

           compoment hoerarchy
                
----------------
    npm install -g @angular/cli


    e2e => test folder
    node-modules => installed packages
    src => source code

    
        angular.json => proj name, cli version
        editorconfig => config file for the editorconfig
        gitignore
        packahge json => which files to be installed in node modules when NPM INSTALL is routing
        tsConfig => compiler options
        tslint.js => rules for compiliing


    app 
        app.module.ts => reference to lib
                        declarations => ref to components is saved
                        imports => modules imported
                        providers => ref to services created 




image = 2020-07-10-19-02-25.png


