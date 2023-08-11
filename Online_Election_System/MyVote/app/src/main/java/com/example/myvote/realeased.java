package com.example.myvote;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class realeased extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_realeased);
        Button butt1 = (Button) findViewById(R.id.btnrelout);
        Button butt2 = (Button) findViewById(R.id.btn19);
        Button butt3 = (Button) findViewById(R.id.btn15);
        Button butt4 = (Button) findViewById(R.id.btn05);
        Button butt5 = (Button) findViewById(R.id.btn99);
        Button butt6 = (Button) findViewById(R.id.btn94);
        Button butt7 = (Button) findViewById(R.id.btn88);
        Button butt8 = (Button) findViewById(R.id.btn82);

        butt1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent int1 = new Intent(realeased.this, MainActivity.class);
                startActivity(int1);


            }
        });
        butt2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent int2 = new Intent(realeased.this, electone.class);
                startActivity(int2);


            }
        });

        butt3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent int3 = new Intent(realeased.this, electiontwo.class);
                startActivity(int3);


            }
        });
        butt4.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent int4 = new Intent(realeased.this, electthiree.class);
                startActivity(int4);


            }
        });

        butt5.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent int5 = new Intent(realeased.this, electfour.class);
                startActivity(int5);


            }
        });
        butt6.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent int6 = new Intent(realeased.this, electfive.class);
                startActivity(int6);


            }
        });

        butt7.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent int7 = new Intent(realeased.this, electsix.class);
                startActivity(int7);


            }
        });

        butt8.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent int8 = new Intent(realeased.this, electseven.class);
                startActivity(int8);


            }
        });








    }
}
