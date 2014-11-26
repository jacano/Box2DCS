﻿using System;
using System.Collections.Generic;
using System.Linq;
using Box2DCS;
using Foundation;
using UIKit;

namespace Box2DCSiOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations
        UIWindow window;

        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            // create a new window instance based on the screen size
            window = new UIWindow(UIScreen.MainScreen.Bounds);

            // If you have defined a view, add it here:
            // window.RootViewController  = navigationController;

            CallBox2D();

            // make the window visible
            window.MakeKeyAndVisible();

            return true;
        }

        private void CallBox2D()
        {
            b2Vec2 gravity = new b2Vec2(0.0f, -10.0f);

            b2World world = new b2World(gravity);

            b2BodyDef groundBodyDef = new b2BodyDef();
            groundBodyDef.position.Set(0.0f, -10.0f);

            b2Body groundBody = world.CreateBody(groundBodyDef);

            b2PolygonShape groundBox = new b2PolygonShape();
            groundBox.SetAsBox(50.0f, 10.0f);

            groundBody.CreateFixture(groundBox, 0.0f);

            b2BodyDef bodyDef = new b2BodyDef();
            bodyDef.type = b2BodyType.b2_dynamicBody;
            bodyDef.position.Set(0.0f, 4.0f);

            b2Body body = world.CreateBody(bodyDef);

            b2PolygonShape dynamicBox = new b2PolygonShape();
            dynamicBox.SetAsBox(1.0f, 1.0f);

            b2FixtureDef fixtureDef = new b2FixtureDef();
            fixtureDef.shape = dynamicBox;
            fixtureDef.density = 1.0f;
            fixtureDef.friction = 0.3f;
            body.CreateFixture(fixtureDef);

            float timeStep = 1.0f / 60.0f;
            int velocityIteration = 6;
            int positionIteration = 2;

            for (int i = 0; i < 60; ++i)
            {
                world.Step(timeStep, velocityIteration, positionIteration);

                b2Vec2 position = body.GetPosition();
                float angle = body.GetAngle();

                Console.WriteLine("{0} {1} {2}", String.Format("{0:F2}", position.x), String.Format("{0:F2}", position.y), String.Format("{0:F2}", angle));
            }

            Console.ReadLine();
        }
    }
}