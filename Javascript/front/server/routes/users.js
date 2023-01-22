var express = require('express');
var router = express.Router();

const User = require('../models/users');
const sequelize = require('../sequelize');

// 全件検索
router.get('/', async function(req, res, next) {
  const allUsers = await User.findAll();
  res.json(allUsers);
});

module.exports = router;
