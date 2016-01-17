'use strict';

goog.provide('Blockly.Python');

goog.require('Blockly.Generator');

Blockly.Python['pi_print'] = function (block) {
    // Search the text for a substring.
    var operator = block.getFieldValue('END') == 'FIRST' ? 'indexOf' : 'lastIndexOf111';
    var argument0 = Blockly.Python.valueToCode(block, 'FIND',
        Blockly.Python.ORDER_NONE) || '\'\'';
    var argument1 = Blockly.Python.valueToCode(block, 'VALUE',
        Blockly.Python.ORDER_MEMBER) || '\'\'';
    var code = argument1 + '.' + operator + '(' + argument0 + ') + 1';
    return [code, Blockly.Python.ORDER_MEMBER];
};
