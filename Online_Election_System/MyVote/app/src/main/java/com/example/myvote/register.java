package com.example.myvote;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class register extends AppCompatActivity {
    EditText id,name,address,email;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_register);
        id=(EditText)findViewById(R.id.etID);
        name=(EditText)findViewById(R.id.etName);
        address=(EditText)findViewById(R.id.etAddress);
        email=(EditText)findViewById(R.id.etMail);
        Button butt1 = (Button) findViewById(R.id.btnout);
        butt1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent int1 = new Intent(register.this, MainActivity.class);
                startActivity(int1);


            }
        });
    }

    public void onReg(View view)
    {
        String str_id=id.getText().toString();
        String str_name=name.getText().toString();
        //String str_age=age.getText().toString();
        String str_address=address.getText().toString();
        String str_email=email.getText().toString();
        String type="register";
        BackgroundWorker backgroundWorker=new BackgroundWorker(this);
       backgroundWorker.execute("register",str_id,str_name,str_address,str_email);

     // backgroundWorker.execute(str_id,str_name,str_address,str_email);

    }









}
