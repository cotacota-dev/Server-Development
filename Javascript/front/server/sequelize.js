'use strict';

const Sequelize = require('sequelize');

const sequelize = new Sequelize('postgres', 'postgres', 'postgres', {
  dialect: 'postgres',
  host: 'host.docker.internal',
  define: {
    underscored: true,
  },
});

// モデルの定義に合わせて、テーブルを強制的にDROPしてCREATEする(本番環境で使わないように！)
sequelize.sync({ force: false });

module.exports = sequelize;