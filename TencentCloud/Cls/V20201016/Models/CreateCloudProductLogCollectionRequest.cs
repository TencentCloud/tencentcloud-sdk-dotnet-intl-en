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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCloudProductLogCollectionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Instance ID</p><ul><li>Obtained through official documentation of connected cloud services</li></ul>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Cloud product identifier. Support the following products</p><ul><li>APIS</li><li>BH</li><li>CDB</li><li>CDS</li><li>CFS</li><li>CLB</li><li>CSIP</li><li>CWP</li><li>DCDB</li><li>DNSPod</li><li>EMR</li><li>HTTPDNS</li><li>KHL</li><li>llmsgw</li><li>MariaDB</li><li>MDP</li><li>MongoDB</li><li>PostgreSQL</li><li>TCSS</li><li>TDSQL-C</li><li>TDStore</li><li>TencentDB-Redis</li><li>TEO</li><li>TokenHub</li><li>TSE</li></ul>
        /// </summary>
        [JsonProperty("AssumerName")]
        public string AssumerName{ get; set; }

        /// <summary>
        /// <p>Log types supported by each cloud product are as follows:</p><table><thead><tr><th>assumer_name</th><th>Supported log_type</th></tr></thead><tbody><tr><td>APIS</td><td>APIS-ACCESS</td></tr><tr><td>BH</td><td>BH-COMMANDLOG, BH-FILELOG</td></tr><tr><td>CDB</td><td>CDB-AUDIT</td></tr><tr><td>CDS</td><td>CDS-AUDIT, CDS-RISK</td></tr><tr><td>CFS</td><td>CFS-AUDIT</td></tr><tr><td>CLB</td><td>CMR-SPEND</td></tr><tr><td>CSIP</td><td>CSIP</td></tr><tr><td>CWP</td><td>CWP</td></tr><tr><td>DCDB</td><td>DCDB-AUDIT, DCDB-ERROR, DCDB-SLOW</td></tr><tr><td>DNSPod</td><td>DNSPod-RESOLVELOG</td></tr><tr><td>EMR</td><td>EMR-OPERATION</td></tr><tr><td>HTTPDNS</td><td>HTTPDNS-RESOLVELOG</td></tr><tr><td>MariaDB</td><td>MariaDB-AUDIT, MariaDB-ERROR, MariaDB-SLOW</td></tr><tr><td>MDP</td><td>MDP-SSAI</td></tr><tr><td>MongoDB</td><td>MongoDB-AUDIT, MongoDB-ErrorLog, MongoDB-OperationLog, MongoDB-SlowLog</td></tr><tr><td>PostgreSQL</td><td>PostgreSQL-AUDIT, PostgreSQL-ERROR, PostgreSQL-SLOW</td></tr><tr><td>TCSS</td><td>TCSS</td></tr><tr><td>TDSQL-C</td><td>TDSQL-C-AUDIT</td></tr><tr><td>TDStore</td><td>TDMYSQL-SLOW</td></tr><tr><td>TencentDB-Redis</td><td>Redis-AUDIT, Redis-ERROR, Redis-SLOW</td></tr><tr><td>TEO</td><td>TEO-INEFERENCE</td></tr><tr><td>llmsgw</td><td>llmsgw-mcp-security-alarm</td></tr></tbody></table>
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// <p>Product region. Different LogTypes have different input parameter formats:</p><p><strong>Format A: Short region code</strong> (gz / sh / bj …)</p><ul><li>All APIS log types: for example, <code>gz</code></li><li>CDB-AUDIT</li><li>TDSQL-C-AUDIT</li><li>TDMYSQL-SLOW</li><li>All DCDB log types</li><li>All MariaDB log types</li><li>All PostgreSQL log types</li><li>MongoDB-AUDIT (<strong>Note that this is different from SlowLog/ErrorLog/OperationLog</strong>)</li><li>All TencentDB-Redis log types</li><li>EMR-OPERATION</li></ul><p><strong>Format B: Long region code</strong> (ap-guangzhou / ap-shanghai / ap-singapore …)</p><ul><li>All CDS log types: for example, <code>ap-guangzhou</code></li><li>MongoDB-SlowLog / MongoDB-ErrorLog / MongoDB-OperationLog</li><li>DNSPod-RESOLVELOG</li><li>HTTPDNS-RESOLVELOG</li><li>MDP-SSAI</li><li>CFS-AUDIT</li><li>TEO-INEFERENCE</li><li>TokenHub-ActivityLog / TokenHub-AuditLog</li><li>llmsgw-mcp-security-alarm</li><li>CSIP / TCSS / TSE / CWP / KHL and others</li></ul><p><strong>Format C: Dedicated BH Polaris name</strong></p><ul><li>All BH log types: <code>overseas-polaris</code> (Hong Kong (China) and other overseas) / <code>fsi-polaris</code> (financial district) / <code>general-polaris</code> (general zone) / <code>intl-sg-prod</code> (international website)</li></ul>
        /// </summary>
        [JsonProperty("CloudProductRegion")]
        public string CloudProductRegion{ get; set; }

        /// <summary>
        /// <p>CLS target region</p><ul><li>Supported regions: see <a href="https://www.tencentcloud.com/document/api/614/56474?from_cn_redirect=1#.E5.9C.B0.E5.9F.9F.E5.88.97.E8.A1.A8">region list</a> document</li></ul>
        /// </summary>
        [JsonProperty("ClsRegion")]
        public string ClsRegion{ get; set; }

        /// <summary>
        /// <p>Logset name. Required when LogsetId is not specified. If the log set does not exist, it will automatically create one.</p>
        /// </summary>
        [JsonProperty("LogsetName")]
        public string LogsetName{ get; set; }

        /// <summary>
        /// <p>Log topic name. This parameter is required when TopicId is empty. If the log topic does not exist, the system will automatically create one.</p>
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// <p>Log configuration extension info, generally used to store additional log delivery configuration</p>
        /// </summary>
        [JsonProperty("Extend")]
        public string Extend{ get; set; }

        /// <summary>
        /// <p>log set id</p><ul><li>Obtain the log set Id through <a href="https://www.tencentcloud.com/document/api/614/58624?from_cn_redirect=1">Get Logset List</a>.</li></ul>
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }

        /// <summary>
        /// <p>log topic id</p><ul><li>Obtain the log topic Id through <a href="https://www.tencentcloud.com/document/product/614/56454?from_cn_redirect=1">Get Log Topic List</a>.</li></ul>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <p>Tag description list. By specifying this parameter, you can simultaneously bind tags to the appropriate theme. Supports up to 10 tag key-value pairs. The same resource can only be bound to the same tag key.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AssumerName", this.AssumerName);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "CloudProductRegion", this.CloudProductRegion);
            this.SetParamSimple(map, prefix + "ClsRegion", this.ClsRegion);
            this.SetParamSimple(map, prefix + "LogsetName", this.LogsetName);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "Extend", this.Extend);
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

