using System;

class RepeatedElement{

    public static void Main(){
        string str=Console.ReadLine();
        int[] arr =new int[26];  
        for(int i=0;i<str.Length;i++){// --> sandeep
            if(arr[str[i]-'a']==1) continue;
            char chars=str[i];
            arr[str[i]-'a']=1;
            int count=0;
            for(int j=0;j<str.Length;j++){
                if(chars==str[j]) count++;
            }
          if(count>1){
            Console.WriteLine(chars+"\n"+count);
          }
        }

    }
}