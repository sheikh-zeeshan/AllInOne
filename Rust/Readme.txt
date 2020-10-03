cargo new hello --bin (--bin is optional create a binary app by default)
cargo init

rustup
rustc --version

cargo run (at toml file or src level - build + run project)
cargo build (at toml file or src level - build the project)

rustup toolchain list

rustc .\src\main.rs   => compiling  (run then main.exe)
cargo run => at main.ts level

cargo => build system, package manager (build code and download libs)

------------------
Data types
    scalar
        int
        float - by default f64 is declared
        bool
        char
    Compound

    Tuples:
        group togather a variety of types
        comma seprated list of values inside parethenses
        destructing breaks a tuple into parethenses
        access tuples elements by period . 
    
    Array
        collectin of multiple values
        same data type at each index
        fixed length - cannot grow or shri, 
        allocat on stack not on heap

    Ownership => when a block of code owns a resource, it is a ownership
        each value has a variable thats called its Owner
        one owner at a time
        when owner goes out of scope the value gets dropped
    REferening and borrowing
        one owner at a time
    Race condition
        2 or more pointers access the same data at same time
        at least one of the pointers is being used to write to the data
        there is no mechanism being used to sync access to data
    
    slice

    strcture => a user defined data type consists of variables of diff data types
        custom data type
        make up a meaning ful group
        bluding blocks of creating new data types
        struct User {
            userName:String,
            email:String
        }
    
    method
        similar to functions
        declare with functions
        defined with context of struct
        first parameter is always &self

        impl Rectangle{
            fn area(&self) -> u32 {   //self is the instance of strctue, with in a struct
                self.width * self.height
            }
        }
    
    Enum => custom data type which contains  some defined values
        enum is meaning + data
        option enum
        enum coim {
            penny,
            nickel,
        }
    enum Option<T>{
        Some(T),
        None,
    }

    Pattern matching (pending)
    powerful operator in Rust called match
    compare one value against a series of patterns
    execute code based on which pattern get matched
    patterns can have literals, variables names , wild cards etc

    Error
        Recoverable errors = result<T,E>
            file not found
        unrecoveable errors - panic!
            bad thing happen in code
            program prints a failure message , unwinds, clean stack and quits
            common occurance: bugs
    
    Zero cost abstraction => ?

    variable => name given to memory location that act as a container for data  
    constants => fixed varibles that do not changed during execution
    tuples => fixed length , of diff data types
    string => array of chars


    Modules => a module is a namespace which contains the defination of the functions or its types. 
    a module is a collection of items such as functions, traits, struct vblock
    mod: declare new module
    pub: set the accesibility level of functions
    use: to import the module into local scope

    vectors => vector allow you to store more than  one value in a single data strcture that puts
    all the values next to each other in memory
        store value of same data types
        growable
        denoted by vec<T>
        let v:Vec<i32>=Vec::new();

        use iter() method when iteration vector, it pervent moving of Ownership
        to for loop
        can loop vector without iter but cannot use vector after that


    Rust
        variables hold primitive data types
        variables are immutable by default
        rust is  a block-scoped language
    
    shadowing
        change the data type
        let x=10;

        let y=true;
    
    pass value by ref =>
    
    Ownership   
        garbage collection
        programmer free up memory


    Carte
        share functionality
        easy debugginh
        organized code
        maintable code
        code modular

        https://www.javatpoint.com/rust-struct