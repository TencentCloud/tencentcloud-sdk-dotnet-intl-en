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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTopSpaceSchemaTimeSeriesRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Number of returned top databases. Maximum value: 100. Default value: 20.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Field used to sort top databases. Valid values: DataLength, IndexLength, TotalLength, DataFree, FragRatio, TableRows, PhysicalFileSize (supported only by TencentDB for MySQL instances). For TencentDB for MySQL instances, the default value is `PhysicalFileSize`. For other database instances, the default value is `TotalLength`.
        /// </summary>
        [JsonProperty("SortBy")]
        public string SortBy{ get; set; }

        /// <summary>
        /// Start date, such as "2021-01-01". It can be as early as 29 days before the current date and is 6 days before the end date by default.
        /// </summary>
        [JsonProperty("StartDate")]
        public string StartDate{ get; set; }

        /// <summary>
        /// End date, such as "2021-01-01". It can be as early as 29 days before the current date and is the current date by default.
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }

        /// <summary>
        /// Service type. Valid values: mysql (TencentDB for MySQL), cynosdb (TDSQL-C for MySQL). Default value: mysql.
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "SortBy", this.SortBy);
            this.SetParamSimple(map, prefix + "StartDate", this.StartDate);
            this.SetParamSimple(map, prefix + "EndDate", this.EndDate);
            this.SetParamSimple(map, prefix + "Product", this.Product);
        }
    }
}

