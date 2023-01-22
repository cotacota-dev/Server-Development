'use strict';

const { Model, DataTypes } = require('sequelize');
const sequelize = require('../sequelize');

// TODO Userモデルを定義する
class User extends Model {}

User.init(
  {
    userId: {
        type: DataTypes.INTEGER,
        primaryKey: true,
        autoIncrement: true,
    },
    email: DataTypes.STRING,
    password: DataTypes.STRING,
  },
  {
    sequelize,
    modelName: 'user',
    timestamps: false,
  }
);

module.exports = User;