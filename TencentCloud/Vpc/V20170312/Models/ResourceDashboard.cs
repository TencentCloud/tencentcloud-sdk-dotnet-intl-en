/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceDashboard : AbstractModel
    {
        
        /// <summary>
        /// Vpc instance ID, e.g. vpc-f1xjkw1b.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Subnet instance ID, such as subnet-bthucmmy.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Classiclink.
        /// </summary>
        [JsonProperty("Classiclink")]
        public ulong? Classiclink{ get; set; }

        /// <summary>
        /// Direct Connect gateway.
        /// </summary>
        [JsonProperty("Dcg")]
        public ulong? Dcg{ get; set; }

        /// <summary>
        /// Peering connection.
        /// </summary>
        [JsonProperty("Pcx")]
        public ulong? Pcx{ get; set; }

        /// <summary>
        /// The total number of used IP addresses.
        /// </summary>
        [JsonProperty("Ip")]
        public ulong? Ip{ get; set; }

        /// <summary>
        /// NAT gateway.
        /// </summary>
        [JsonProperty("Nat")]
        public ulong? Nat{ get; set; }

        /// <summary>
        /// VPN gateway.
        /// </summary>
        [JsonProperty("Vpngw")]
        public ulong? Vpngw{ get; set; }

        /// <summary>
        /// Flow log.
        /// </summary>
        [JsonProperty("FlowLog")]
        public ulong? FlowLog{ get; set; }

        /// <summary>
        /// Network probing.
        /// </summary>
        [JsonProperty("NetworkDetect")]
        public ulong? NetworkDetect{ get; set; }

        /// <summary>
        /// Network ACL.
        /// </summary>
        [JsonProperty("NetworkACL")]
        public ulong? NetworkACL{ get; set; }

        /// <summary>
        /// Cloud Virtual Machine.
        /// </summary>
        [JsonProperty("CVM")]
        public ulong? CVM{ get; set; }

        /// <summary>
        /// Load balancer.
        /// </summary>
        [JsonProperty("LB")]
        public ulong? LB{ get; set; }

        /// <summary>
        /// Relational database.
        /// </summary>
        [JsonProperty("CDB")]
        public ulong? CDB{ get; set; }

        /// <summary>
        /// TencentDB for Memcached.
        /// </summary>
        [JsonProperty("Cmem")]
        public ulong? Cmem{ get; set; }

        /// <summary>
        /// Cloud time series database.
        /// </summary>
        [JsonProperty("CTSDB")]
        public ulong? CTSDB{ get; set; }

        /// <summary>
        /// TencentDB for MariaDB (TDSQL).
        /// </summary>
        [JsonProperty("MariaDB")]
        public ulong? MariaDB{ get; set; }

        /// <summary>
        /// TencentDB for SQL Server.
        /// </summary>
        [JsonProperty("SQLServer")]
        public ulong? SQLServer{ get; set; }

        /// <summary>
        /// TencentDB for PostgreSQL.
        /// </summary>
        [JsonProperty("Postgres")]
        public ulong? Postgres{ get; set; }

        /// <summary>
        /// Network attached storage.
        /// </summary>
        [JsonProperty("NAS")]
        public ulong? NAS{ get; set; }

        /// <summary>
        /// Snova data warehouse.
        /// </summary>
        [JsonProperty("Greenplumn")]
        public ulong? Greenplumn{ get; set; }

        /// <summary>
        /// Cloud Kafka (CKafka).
        /// </summary>
        [JsonProperty("Ckafka")]
        public ulong? Ckafka{ get; set; }

        /// <summary>
        /// Grocery.
        /// </summary>
        [JsonProperty("Grocery")]
        public ulong? Grocery{ get; set; }

        /// <summary>
        /// Data encryption service.
        /// </summary>
        [JsonProperty("HSM")]
        public ulong? HSM{ get; set; }

        /// <summary>
        /// Game storage - Tcaplus.
        /// </summary>
        [JsonProperty("Tcaplus")]
        public ulong? Tcaplus{ get; set; }

        /// <summary>
        /// Cnas.
        /// </summary>
        [JsonProperty("Cnas")]
        public ulong? Cnas{ get; set; }

        /// <summary>
        /// HTAP database - TiDB.
        /// </summary>
        [JsonProperty("TiDB")]
        public ulong? TiDB{ get; set; }

        /// <summary>
        /// EMR cluster.
        /// </summary>
        [JsonProperty("Emr")]
        public ulong? Emr{ get; set; }

        /// <summary>
        /// SEAL.
        /// </summary>
        [JsonProperty("SEAL")]
        public ulong? SEAL{ get; set; }

        /// <summary>
        /// Cloud file storage - CFS.
        /// </summary>
        [JsonProperty("CFS")]
        public ulong? CFS{ get; set; }

        /// <summary>
        /// Oracle.
        /// </summary>
        [JsonProperty("Oracle")]
        public ulong? Oracle{ get; set; }

        /// <summary>
        /// ElasticSearch Service.
        /// </summary>
        [JsonProperty("ElasticSearch")]
        public ulong? ElasticSearch{ get; set; }

        /// <summary>
        /// Blockchain service.
        /// </summary>
        [JsonProperty("TBaaS")]
        public ulong? TBaaS{ get; set; }

        /// <summary>
        /// Itop.
        /// </summary>
        [JsonProperty("Itop")]
        public ulong? Itop{ get; set; }

        /// <summary>
        /// Cloud database audit.
        /// </summary>
        [JsonProperty("DBAudit")]
        public ulong? DBAudit{ get; set; }

        /// <summary>
        /// Enterprise TencentDB - CynosDB for Postgres.
        /// </summary>
        [JsonProperty("CynosDBPostgres")]
        public ulong? CynosDBPostgres{ get; set; }

        /// <summary>
        /// TencentDB for Redis.
        /// </summary>
        [JsonProperty("Redis")]
        public ulong? Redis{ get; set; }

        /// <summary>
        /// TencentDB for MongoDB.
        /// </summary>
        [JsonProperty("MongoDB")]
        public ulong? MongoDB{ get; set; }

        /// <summary>
        /// A distributed cloud database - TencentDB for TDSQL.
        /// </summary>
        [JsonProperty("DCDB")]
        public ulong? DCDB{ get; set; }

        /// <summary>
        /// An enterprise-grade TencentDB - CynosDB for MySQL.
        /// </summary>
        [JsonProperty("CynosDBMySQL")]
        public ulong? CynosDBMySQL{ get; set; }

        /// <summary>
        /// Subnets.
        /// </summary>
        [JsonProperty("Subnet")]
        public ulong? Subnet{ get; set; }

        /// <summary>
        /// Route table.
        /// </summary>
        [JsonProperty("RouteTable")]
        public ulong? RouteTable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Classiclink", this.Classiclink);
            this.SetParamSimple(map, prefix + "Dcg", this.Dcg);
            this.SetParamSimple(map, prefix + "Pcx", this.Pcx);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Nat", this.Nat);
            this.SetParamSimple(map, prefix + "Vpngw", this.Vpngw);
            this.SetParamSimple(map, prefix + "FlowLog", this.FlowLog);
            this.SetParamSimple(map, prefix + "NetworkDetect", this.NetworkDetect);
            this.SetParamSimple(map, prefix + "NetworkACL", this.NetworkACL);
            this.SetParamSimple(map, prefix + "CVM", this.CVM);
            this.SetParamSimple(map, prefix + "LB", this.LB);
            this.SetParamSimple(map, prefix + "CDB", this.CDB);
            this.SetParamSimple(map, prefix + "Cmem", this.Cmem);
            this.SetParamSimple(map, prefix + "CTSDB", this.CTSDB);
            this.SetParamSimple(map, prefix + "MariaDB", this.MariaDB);
            this.SetParamSimple(map, prefix + "SQLServer", this.SQLServer);
            this.SetParamSimple(map, prefix + "Postgres", this.Postgres);
            this.SetParamSimple(map, prefix + "NAS", this.NAS);
            this.SetParamSimple(map, prefix + "Greenplumn", this.Greenplumn);
            this.SetParamSimple(map, prefix + "Ckafka", this.Ckafka);
            this.SetParamSimple(map, prefix + "Grocery", this.Grocery);
            this.SetParamSimple(map, prefix + "HSM", this.HSM);
            this.SetParamSimple(map, prefix + "Tcaplus", this.Tcaplus);
            this.SetParamSimple(map, prefix + "Cnas", this.Cnas);
            this.SetParamSimple(map, prefix + "TiDB", this.TiDB);
            this.SetParamSimple(map, prefix + "Emr", this.Emr);
            this.SetParamSimple(map, prefix + "SEAL", this.SEAL);
            this.SetParamSimple(map, prefix + "CFS", this.CFS);
            this.SetParamSimple(map, prefix + "Oracle", this.Oracle);
            this.SetParamSimple(map, prefix + "ElasticSearch", this.ElasticSearch);
            this.SetParamSimple(map, prefix + "TBaaS", this.TBaaS);
            this.SetParamSimple(map, prefix + "Itop", this.Itop);
            this.SetParamSimple(map, prefix + "DBAudit", this.DBAudit);
            this.SetParamSimple(map, prefix + "CynosDBPostgres", this.CynosDBPostgres);
            this.SetParamSimple(map, prefix + "Redis", this.Redis);
            this.SetParamSimple(map, prefix + "MongoDB", this.MongoDB);
            this.SetParamSimple(map, prefix + "DCDB", this.DCDB);
            this.SetParamSimple(map, prefix + "CynosDBMySQL", this.CynosDBMySQL);
            this.SetParamSimple(map, prefix + "Subnet", this.Subnet);
            this.SetParamSimple(map, prefix + "RouteTable", this.RouteTable);
        }
    }
}

