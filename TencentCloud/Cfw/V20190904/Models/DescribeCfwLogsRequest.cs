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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCfwLogsRequest : AbstractModel
    {
        
        /// <summary>
        /// Log type. Required for the initial query; cannot be passed when using NextToken for continuation. cfw_netflow_border=Internet boundary traffic, cfw_netflow_vpc=VPC east-west traffic, cfw_netflow_nat=NAT firewall traffic, cfw_netflow_nta=NDR/NTA traffic, cfw_netflow_dns=DNS firewall log, cfw_rule_threatinfo=Intrusion defense/Threat Intelligence Alarm, cfw_rule_acl=Internet Boundary Access Control log, cfw_rule_vpc_acl=VPC access control log, cfw_rule_nat_acl=NAT access control log, cfw_ndr_subject_risk=NDR topic risk, cfw_ndr_dataleak_entry=NDR sensitive data leak, cfw_ndr_ai_audit=NDR AI application identification and Large Model Invocation audit, cfw_feature_collect=Statistical feature and baseline anomaly, cfw_behavior_collect=Beacon/DNS/port/cert/VPC mutual access behavior, operate_log_all=Operation audit log.
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// Log filter expression. Default * means no filtering; for example src_ip:1.1.1.1. Queryable fields vary with LogType. You should preferentially use the field name returned in the corresponding Items. Do not guess non-existing fields. It cannot be passed when using NextToken for continued query.
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// Query start time. Supports RFC3339, YYYY-MM-DD HH:MM:SS, YYYY-MM-DD, or Unix timestamp. Input to query the TimeRange backward from this time. Cannot be imported when using NextToken for continued querying.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Query time range. Default 1h; format is positive integer plus unit m/h/d, such as 5m, 1h, 24h, 7d; cannot be passed when using NextToken for continuation.
        /// </summary>
        [JsonProperty("TimeRange")]
        public string TimeRange{ get; set; }

        /// <summary>
        /// Return limit. Selectable for initial query, default 100; value 1 to 1000; cannot be passed when using NextToken for continued query.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Previous page opaque continuation token returned by Response.Data. Not required for initial query; only required for continuation query with NextToken. Invalid, tampered, or mismatched tenant will be rejected.
        /// </summary>
        [JsonProperty("NextToken")]
        public string NextToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "TimeRange", this.TimeRange);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
        }
    }
}

