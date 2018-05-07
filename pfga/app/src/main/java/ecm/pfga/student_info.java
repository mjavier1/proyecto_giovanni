package ecm.pfga;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class student_info extends Activity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_student_info);

        Button btn_submitInfo = findViewById(R.id.btn_submit);
        btn_submitInfo.setOnClickListener(
                new Button.OnClickListener(){
                    @Override
                    public void onClick(View v) {
                        Intent intent = new Intent(student_info.this, student_activities.class);
                        startActivity(intent);
                    }
                }
        );
    }
}
