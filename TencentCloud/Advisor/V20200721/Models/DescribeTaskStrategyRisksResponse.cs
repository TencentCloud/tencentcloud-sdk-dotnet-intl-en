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

namespace TencentCloud.Advisor.V20200721.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTaskStrategyRisksResponse : AbstractModel
    {
        
        /// <summary>
        /// According to this configuration, match the corresponding fields of the risky instance list (Risks), for example:
        /// {"Response":{"RequestId":"111","RiskFieldsDesc":[{"Field":"InstanceId","FieldName":"ID","FieldType":"string","FieldDict":{} },{"Field":"InstanceName","FieldName":"Name","FieldType":"string","FieldDict":{}},{"Field":"InstanceState","FieldName":"Status ","FieldType":"string","FieldDict":{"LAUNCH_FAILED":"Creation failed","PENDING":"Creating","REBOOTING":"Re- starting","RUNNING":"Running","SHUTDOWN":"Stop waiting to be terminated","STARTING":"Starting","STOPPED":"Shut down","STOPPING":"Shutting down"," TERMINATING":"Terminating"}},{"Field":"Zone","FieldName":"Available zone","FieldType":"string","FieldDict":{}},{"Field":" PrivateIPAddresses","FieldName":"Private IP addresses","FieldType":"stringSlice","FieldDict":{}},{"Field":"PublicIPAddresses","FieldName":"Public IP addresses","Field Type":"stringSlice","FieldDict":{}},{"Field":"Region","FieldName":"Region","FieldType":"string","FieldDict":{}},{" Field":"Tags","FieldName":"Tags","FieldType":"tags","FieldDict":{}}],"RiskTotalCount":3,"Risks":"[{\"InstanceId\" :\"ins-xxx1\",\"InstanceName\":\"xxx1\",\"InstanceState\":\"RUNNING\",\"PrivateIPAddresses\":[\"1.17.64.2\"],\ " PublicIPAddresses\":null,\"Region\":\"ap-shanghai\",\"Tags\":null,\"Zone\":\"ap-shanghai-2\"},{\"InstanceId\ ":\"ins-xxx2\",\"InstanceName\":\"xxx2\",\"InstanceState\":\"RUNNING\",\"PrivateIPAddresses\":[\"1.17.64.11\"], \"PublicIPAddresses\":null,\"Region\":\"ap-shanghai\",\"Tags\":null,\"Zone\":\"ap-shanghai-2\"}]"," StrategyId":9}}
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RiskFieldsDesc")]
        public RiskFieldsDesc[] RiskFieldsDesc{ get; set; }

        /// <summary>
        /// Assessment item ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StrategyId")]
        public ulong? StrategyId{ get; set; }

        /// <summary>
        /// Number of risky instances
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RiskTotalCount")]
        public ulong? RiskTotalCount{ get; set; }

        /// <summary>
        /// Risky instance details list. Require json decode.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Risks")]
        public string Risks{ get; set; }

        /// <summary>
        /// Number of inspection resources
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResourceCount")]
        public ulong? ResourceCount{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "RiskFieldsDesc.", this.RiskFieldsDesc);
            this.SetParamSimple(map, prefix + "StrategyId", this.StrategyId);
            this.SetParamSimple(map, prefix + "RiskTotalCount", this.RiskTotalCount);
            this.SetParamSimple(map, prefix + "Risks", this.Risks);
            this.SetParamSimple(map, prefix + "ResourceCount", this.ResourceCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}
