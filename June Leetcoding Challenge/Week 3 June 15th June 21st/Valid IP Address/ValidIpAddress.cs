public class Solution {
    
    public bool answer4;
    public bool answer6;
    
    public string ValidIPAddress(string IP) {
    
        answer4 = checkIPv4(IP);
        answer6 = checkIPv6(IP);
        
        if(answer4 == true)
            return("IPv4");
        
        if(answer6 == true)
        {
            return("IPv6");
        }
        
        return("Neither");
    }
    
    public bool checkIPv4(string IP)
    {
        //Checks to see if has 4 number
        string[] digits = IP.Split('.');
        if(digits.Length != 4)
            return false;
        
        foreach(string x in digits)
        {
            //Checks if is a number
            if(!(x.All(char.IsNumber)))
                return false;
            
            //Checks if has at least 1 value
            if(x.Length < 1 || x.Length > 3)
                return false;
            
            //Checks for leading 0
            if( x.Length > 1 && x[0] == '0')
                return false;
            
            //Checks if number is within range
            if(Convert.ToInt32(x) > 255 || Convert.ToInt32(x) < 0)
                return false;
        }
        
        return true;
    }
    
    public bool checkIPv6(string IP)
    {
        string[] digits = IP.Split(':');
        if(digits.Length != 8)
            return false;
        
        foreach(string x in digits)
        {
            //Checks if length of string is between 4 and 1
            if(x.Length > 4 || x.Length < 1)
                return false;
                
            //Checks if all values are digits or letters
            int res = 0; 
            if(!x.All("0123456789abcdefABCDEFabcdef".Contains)) 
            {
                  return false;
            }
        }
        
        return true;
    }
}