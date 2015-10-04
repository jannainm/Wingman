//
//  SecondViewController.swift
//  Wingman_MAIN
//
//  Created by Michael Jannain on 10/3/15.
//  Copyright (c) 2015 Michael Jannain. All rights reserved.
//

import UIKit

class SecondViewController: UIViewController {

    /*
    // Only override drawRect: if you perform custom drawing.
    // An empty implementation adversely affects performance during animation.
    override func drawRect(rect: CGRect) {
        // Drawing code
    }
    */

    @IBAction func send1(sender: AnyObject) {
        let alertController = UIAlertController(title: "SMS Alert", message: "SMS messages successfully sent.", preferredStyle: .Alert)
        let dismissAction = UIAlertAction(title: "Dismiss", style: .Default) { (_) in }
        alertController.addAction(dismissAction)
        self.presentViewController(alertController, animated: true) { (_) in}
     }
}
