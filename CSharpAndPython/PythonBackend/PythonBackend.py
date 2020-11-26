import sys 


def Exponent(a,b):
    """ Raise a to the power of b """
    try:
        return a**b
    except:
        raise ValueError()

if __name__ == "__main__":

    print("Hello, This is Python!")

    #a = sys.argv[1]
    #b = sys.argv[2]

    a,b = 2 , 10
    print(str(a)+"^"+str(b)+"=",Exponent(a,b))

    print("Python is done, goodbye!")
    
