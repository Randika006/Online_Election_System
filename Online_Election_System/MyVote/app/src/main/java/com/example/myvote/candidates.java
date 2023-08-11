package com.example.myvote;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class candidates extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_candidates);
        Button butt1 = (Button) findViewById(R.id.btncout);
        Button butt2 = (Button) findViewById(R.id.btngt);
        Button butt3 = (Button) findViewById(R.id.btnsj);
        Button butt4 = (Button) findViewById(R.id.btnan);
        Button butt5 = (Button) findViewById(R.id.btnot);

        butt1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent int1 = new Intent(candidates.this, MainActivity.class);
                startActivity(int1);


            }
        });

        butt2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent int2 = new Intent(candidates.this, gotabaya.class);
                startActivity(int2);


            }
        });

        butt3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent int3 = new Intent(candidates.this, sajith.class);
                startActivity(int3);


            }
        });
        butt4.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent int4 = new Intent(candidates.this, anura.class);
                startActivity(int4);


            }
        });

        butt5.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent int5 = new Intent(candidates.this, other.class);
                startActivity(int5);


            }
        });









    }
}
