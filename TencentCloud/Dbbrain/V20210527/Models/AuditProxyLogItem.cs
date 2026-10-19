/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuditProxyLogItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Time point of SQL execution (format string, yyyy-MM-dd HH:mm:ss).</p>
        /// </summary>
        [JsonProperty("Timestamp")]
        public string Timestamp{ get; set; }

        /// <summary>
        /// <p>Cluster ID (dcdb/mariadb cluster identifier, same as InstanceId).</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>Number of affected rows.</p>
        /// </summary>
        [JsonProperty("AffectRows")]
        public long? AffectRows{ get; set; }

        /// <summary>
        /// <p>Whether to autocommit. 1 means enabling, and 0 means disabling.</p>
        /// </summary>
        [JsonProperty("Autocommit")]
        public string Autocommit{ get; set; }

        /// <summary>
        /// <p>MySQL network protocol command types (such as COM_QUERY and COM_CONNECT).</p>
        /// </summary>
        [JsonProperty("ComType")]
        public string ComType{ get; set; }

        /// <summary>
        /// <p>Duration of creating a connection.</p>
        /// </summary>
        [JsonProperty("ConnTc")]
        public long? ConnTc{ get; set; }

        /// <summary>
        /// <p>Backend DB instance address (multiple entries are separated by commas).</p>
        /// </summary>
        [JsonProperty("DBHost")]
        public string DBHost{ get; set; }

        /// <summary>
        /// <p>Database name where the SQL is executed.</p>
        /// </summary>
        [JsonProperty("DBName")]
        public string DBName{ get; set; }

        /// <summary>
        /// <p>Error code returned by SQL execution. 0 indicates success.</p>
        /// </summary>
        [JsonProperty("ErrCode")]
        public string ErrCode{ get; set; }

        /// <summary>
        /// <p>Error message.</p>
        /// </summary>
        [JsonProperty("ErrInfo")]
        public string ErrInfo{ get; set; }

        /// <summary>
        /// <p>SQL execution time (µs).</p>
        /// </summary>
        [JsonProperty("ExecTime")]
        public long? ExecTime{ get; set; }

        /// <summary>
        /// <p>Number of connections still occupied after request ends (typically 0 for non-transaction requests).</p>
        /// </summary>
        [JsonProperty("HoldConns")]
        public string HoldConns{ get; set; }

        /// <summary>
        /// <p>Client source IP.</p>
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// <p>Whether to enable global consistency read (0: no, 1: yes).</p>
        /// </summary>
        [JsonProperty("Mc")]
        public string Mc{ get; set; }

        /// <summary>
        /// <p>SQL start time (microsecond portion in microsecond precision).</p>
        /// </summary>
        [JsonProperty("SqlStartTimeUs")]
        public long? SqlStartTimeUs{ get; set; }

        /// <summary>
        /// <p>Number of connections created in the current request.</p>
        /// </summary>
        [JsonProperty("NewConnNum")]
        public long? NewConnNum{ get; set; }

        /// <summary>
        /// <p>Proxy node address.</p>
        /// </summary>
        [JsonProperty("ProxyHost")]
        public string ProxyHost{ get; set; }

        /// <summary>
        /// <p>Proxy ID.</p>
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// <p>Query ID (used for join queries).</p>
        /// </summary>
        [JsonProperty("QueryId")]
        public string QueryId{ get; set; }

        /// <summary>
        /// <p>Number of rows returned (rows in the scanning result set).</p>
        /// </summary>
        [JsonProperty("SentRows")]
        public long? SentRows{ get; set; }

        /// <summary>
        /// <p>Whether it is a query rewritten by Proxy: 0 original query, 1 rewritten query.</p>
        /// </summary>
        [JsonProperty("Splited")]
        public long? Splited{ get; set; }

        /// <summary>
        /// <p>Original executed SQL statement.</p>
        /// </summary>
        [JsonProperty("Sql")]
        public string Sql{ get; set; }

        /// <summary>
        /// <p>SQL template.</p>
        /// </summary>
        [JsonProperty("SqlTemplate")]
        public string SqlTemplate{ get; set; }

        /// <summary>
        /// <p>SQL Template ID.</p>
        /// </summary>
        [JsonProperty("SqlTemplateId")]
        public string SqlTemplateId{ get; set; }

        /// <summary>
        /// <p>SQL type (for example, Select, Insert, Create, Login, Set).</p>
        /// </summary>
        [JsonProperty("SqlType")]
        public string SqlType{ get; set; }

        /// <summary>
        /// <p>Tables involved (separated by commas for multiple tables).</p>
        /// </summary>
        [JsonProperty("Tables")]
        public string Tables{ get; set; }

        /// <summary>
        /// <p>Thread ID.</p>
        /// </summary>
        [JsonProperty("ThreadId")]
        public string ThreadId{ get; set; }

        /// <summary>
        /// <p>SQL start time (millisecond-level timestamp).</p>
        /// </summary>
        [JsonProperty("SqlStartTime")]
        public long? SqlStartTime{ get; set; }

        /// <summary>
        /// <p>Database username that executes the SQL.</p>
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// <p>HostPort of the client connection.</p>
        /// </summary>
        [JsonProperty("HostPort")]
        public string HostPort{ get; set; }

        /// <summary>
        /// <p>Proxy Node processing thread ID.</p>
        /// </summary>
        [JsonProperty("ProxyThread")]
        public string ProxyThread{ get; set; }

        /// <summary>
        /// <p>Number of backend DB hosts.</p>
        /// </summary>
        [JsonProperty("DbHostNum")]
        public string DbHostNum{ get; set; }

        /// <summary>
        /// <p>Business code (extracted from i/o/p and other KV in business-side SQL annotations).</p>
        /// </summary>
        [JsonProperty("BusinessCode")]
        public string BusinessCode{ get; set; }

        /// <summary>
        /// <p>Business tag (completed post based on the business code).</p>
        /// </summary>
        [JsonProperty("BusinessTag")]
        public string BusinessTag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "AffectRows", this.AffectRows);
            this.SetParamSimple(map, prefix + "Autocommit", this.Autocommit);
            this.SetParamSimple(map, prefix + "ComType", this.ComType);
            this.SetParamSimple(map, prefix + "ConnTc", this.ConnTc);
            this.SetParamSimple(map, prefix + "DBHost", this.DBHost);
            this.SetParamSimple(map, prefix + "DBName", this.DBName);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "ErrInfo", this.ErrInfo);
            this.SetParamSimple(map, prefix + "ExecTime", this.ExecTime);
            this.SetParamSimple(map, prefix + "HoldConns", this.HoldConns);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "Mc", this.Mc);
            this.SetParamSimple(map, prefix + "SqlStartTimeUs", this.SqlStartTimeUs);
            this.SetParamSimple(map, prefix + "NewConnNum", this.NewConnNum);
            this.SetParamSimple(map, prefix + "ProxyHost", this.ProxyHost);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "QueryId", this.QueryId);
            this.SetParamSimple(map, prefix + "SentRows", this.SentRows);
            this.SetParamSimple(map, prefix + "Splited", this.Splited);
            this.SetParamSimple(map, prefix + "Sql", this.Sql);
            this.SetParamSimple(map, prefix + "SqlTemplate", this.SqlTemplate);
            this.SetParamSimple(map, prefix + "SqlTemplateId", this.SqlTemplateId);
            this.SetParamSimple(map, prefix + "SqlType", this.SqlType);
            this.SetParamSimple(map, prefix + "Tables", this.Tables);
            this.SetParamSimple(map, prefix + "ThreadId", this.ThreadId);
            this.SetParamSimple(map, prefix + "SqlStartTime", this.SqlStartTime);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "HostPort", this.HostPort);
            this.SetParamSimple(map, prefix + "ProxyThread", this.ProxyThread);
            this.SetParamSimple(map, prefix + "DbHostNum", this.DbHostNum);
            this.SetParamSimple(map, prefix + "BusinessCode", this.BusinessCode);
            this.SetParamSimple(map, prefix + "BusinessTag", this.BusinessTag);
        }
    }
}

