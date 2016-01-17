'use strict';

goog.provide('Blockly.Blocks.pi');

goog.require('Blockly.Blocks');


/**
 * Common HSV hue for all blocks in this category.
 */
Blockly.Blocks.pi.HUE = 160;

Blockly.Blocks['pi_blink'] = {
    /**
     * Block for print statement.
     * @this Blockly.Block
     */
    init: function() {
        this.jsonInit({
            "message0": "Моргнуть"
        });
        this.setColour(Blockly.Blocks.texts.HUE);
        this.appendDummyInput()
            .appendField(new Blockly.FieldTextInput('1'), 'DELAY');
        this.setPreviousStatement(true, "null");
        this.setNextStatement(true, "null");
    }
};
