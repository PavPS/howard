'use strict';

goog.provide('Blockly.Python');

goog.require('Blockly.Generator');

Blockly.Python['pi_blink'] = function (block) {

    var arg = block.getFieldValue('DELAY');
    var action = "time.sleep(" + arg + ")";
    var code = "GPIO.setup(21, GPIO.OUT)\nGPIO.output(21, True)\n" + action + "\nGPIO.output(21, False)\n";
    return code;
};
