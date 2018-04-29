using UnityEngine;

using System.Collections;


	public class dla : MonoBehaviour {


	public const int L=100;
	public const int N=3000;
	public const int R=2;
	public float r=2;
	public int d=2;
	public const int P=1;
	public int T=0;
	//public GameObject GO;
	public GameObject GP;
	public struct particle{
		public int x;
		public int y;
		public int z;
	}
	bool[,,] Lattice=new bool[L,L,L];
	particle[] A= new particle[P];
	
	void Set(){
            int i=0;
            A[i].x=(int)(Random.value*2*(r+d)+L/2-r-d-1);
            A[i].y=(int)(Random.value*2*(r+d)+L/2-r-d-1);
            A[i].z=(int)(Random.value*2*(r+d)+L/2-r-d-1);
    }
	
	void Start () {
		for(int i=0;i<L;i++)
			for(int j=0;j<L;j++)
				for(int k=0;k<L;k++)
					Lattice[i,j,k]=false;
		for(int i=L/2-R;i<L/2+R;i++)
			for(int j=L/2-R;j<L/2+R;j++)
				for(int k=L/2-R;k<L/2+R;k++){
                    if((j-L/2)*(j-L/2)+(i-L/2)*(i-L/2)+(k-L/2)*(k-L/2)<=R*R)                    
                        Lattice[i,j,k]=true;
				/*	if((j-L/2)*(j-L/2)+(i-L/2)*(i-L/2)+(k-L/2)*(k-L/2)<R*R+20 && (j-L/2)*(j-L/2)+(i-L/2)*(i-L/2)+(k-L/2)*(k-L/2)>R*R-20){
                        Rigidbody clone;	
				        clone=Instantiate(GO,new Vector3(i-L/2,j-L/2,k-L/2),Quaternion.identity) as Rigidbody;
                    }*/
                }
        Set();
    }
	void Update (){
        int m;
		int j=0;
		if(T<N)
		for(int i=0;i<10000;i++){
		if(Lattice[A[j].x,A[j].y,A[j].z]==false){
			if(Lattice[A[j].x-1,A[j].y,A[j].z]==true || Lattice[A[j].x+1,A[j].y,A[j].z]==true || Lattice[A[j].x,A[j].y+1,A[j].z]==true || Lattice[A[j].x,A[j].y-1,A[j].z]==true || Lattice[A[j].x-1,A[j].y,A[j].z+1]==true || Lattice[A[j].x-1,A[j].y,A[j].z-1]==true){
				Lattice[A[j].x,A[j].y,A[j].z]=true;
				T++;
      			Rigidbody clone;
				clone=Instantiate(GP,new Vector3(A[j].x-L/2,A[j].y-L/2,A[j].z-L/2),Quaternion.identity) as Rigidbody;
				Debug.Log("MAM!");
				r=Mathf.Max(r,Mathf.Sqrt((A[j].x-L/2)*(A[j].x-L/2)+(A[j].y-L/2)*(A[j].y-L/2)+(A[j].z-L/2)*(A[j].z-L/2)));
				Debug.Log(r);
				Debug.Log(Mathf.Sqrt((A[j].x-L/2)*(A[j].x-L/2)+(A[j].y-L/2)*(A[j].y-L/2)+(A[j].z-L/2)*(A[j].z-L/2)));
				Set();
				break;
			}	
			m=(int)(Random.value*6);		
			switch(m){
				case 0:
					if(A[j].x-1<1)
						break;
					else
						A[j].x--;
					break;
				case 1:
					if(A[j].x+1>L-2)
						break;
					else
						A[j].x++;
					break;
				case 2:
					if(A[j].y-1<1)
						break;
					else
						A[j].y--;
					break;
				case 3:
					if(A[j].y+1>L-2)
						break;
					else
						A[j].y++;
					break;
				case 4:
					if(A[j].z-1<1)
						break;
					else
						A[j].z--;
					break;
				case 5:
					if(A[j].z+1>L-2)
						break;
					else
						A[j].z++;
					break;
			 }
		
	   }
	   else{
            Set();
            Debug.Log("Setuje!");
            break;
        }
    }
    }
}
