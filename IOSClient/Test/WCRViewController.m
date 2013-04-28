//
//  WCRViewController.m
//  Test
//
//  Created by Watcher on 13-4-27.
//  Copyright (c) 2013年 Watcher. All rights reserved.
//

#import "WCRViewController.h"
#import "ASIHTTPRequest.h"
@interface WCRViewController ()

@end

@implementation WCRViewController

@synthesize point;

- (void)viewDidLoad
{
    [super viewDidLoad];
	// Do any additional setup after loading the view, typically from a nib.
}

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

//-(void)touchesBegan:(NSSet *)touches withEvent:(UIEvent *)event
//{
//  point=[[touches anyObject]locationInView:self.view];
//}

-(void)touchesMoved:(NSSet *)touches withEvent:(UIEvent *)event
{
   point= [[touches anyObject]locationInView:self.view];
    [self callService:point];
}

- (void)callService:(CGPoint)point{

    NSString *URLString=[[NSString alloc]initWithFormat:@"%@%f,%f",@"http://192.168.150.39:9998/PointService/Service/",point.x,point.y];
    NSURL *url = [NSURL URLWithString:URLString];
    ASIHTTPRequest *request = [ASIHTTPRequest requestWithURL:url];
    [request startSynchronous];
    NSError *error = [request error];
//    if (!error) {
//        NSString *response = [request responseString];
////        UIAlertView *alertView = [[UIAlertView alloc] initWithTitle:@"JSON格式"
////                                                            message:response
////                                                           delegate:nil
////                                                  cancelButtonTitle:@"OK"
////                                                  otherButtonTitles:nil];
////        [alertView show];
////        [alertView release];
//    }
}

@end
