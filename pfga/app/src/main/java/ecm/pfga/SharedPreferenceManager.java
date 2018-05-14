package ecm.pfga;

import android.content.Context;
import android.content.SharedPreferences;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.toolbox.Volley;

public class SharedPreferenceManager {
    private static SharedPreferenceManager mInstance;

    private static Context mCtx;
    private static final String SHARED_PREF_NAME = "mysharedpref12";
    private static final String KEY_USERNAME = "username";
    private static final String KEY_USER_EMAIL = "useremail";
    private static final String KEY_USER_ID = "userid";
    private SharedPreferenceManager(Context context){
        mCtx = context;

    }

    public static synchronized SharedPreferenceManager getInstance(Context context) {
        if (mInstance == null){
            mInstance = new SharedPreferenceManager(context);
        }
        return mInstance;
    }

    public boolean userLogin(int id, String username, String email){
        SharedPreferences sharedPreferences = mCtx.getSharedPreferences()
    }
}
