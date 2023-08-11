package com.example.myvote;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class login extends AppCompatActivity {
    EditText UsernameEt,PasswordEt;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);
        UsernameEt=(EditText)findViewById(R.id.etUserNaame);
        PasswordEt=(EditText)findViewById(R.id.etPassword);
        Button butt1 = (Button) findViewById(R.id.btnvt);
        Button butt2 = (Button) findViewById(R.id.btnrout);

        butt1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent int1 = new Intent(login.this, vote.class);
                startActivity(int1);


            }
        });


        butt2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent int2 = new Intent(login.this, MainActivity.class);
                startActivity(int2);


            }
        });
    }
    public void onLogin(View view)
    {
        String username=UsernameEt.getText().toString();
        String password=PasswordEt.getText().toString();
        String type="login";
        BackgroundWorker backgroundWorker=new BackgroundWorker(this);
        backgroundWorker.execute(type,username,password);



    }







}
