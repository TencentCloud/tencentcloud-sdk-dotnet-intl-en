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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Blueprint : AbstractModel
    {
        
        /// <summary>
        /// Image ID, which is the unique identifier of `Blueprint`.
        /// </summary>
        [JsonProperty("BlueprintId")]
        public string BlueprintId{ get; set; }

        /// <summary>
        /// Image title to be displayed.
        /// </summary>
        [JsonProperty("DisplayTitle")]
        public string DisplayTitle{ get; set; }

        /// <summary>
        /// Image version to be displayed.
        /// </summary>
        [JsonProperty("DisplayVersion")]
        public string DisplayVersion{ get; set; }

        /// <summary>
        /// Image description information.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// OS name.
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// OS type.
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// OS type, such as LINUX_UNIX and WINDOWS.
        /// </summary>
        [JsonProperty("PlatformType")]
        public string PlatformType{ get; set; }

        /// <summary>
        /// Image type, such as APP_OS, PURE_OS, and PRIVATE.
        /// </summary>
        [JsonProperty("BlueprintType")]
        public string BlueprintType{ get; set; }

        /// <summary>
        /// Image picture URL.
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// System disk size required by image in GB.
        /// </summary>
        [JsonProperty("RequiredSystemDiskSize")]
        public long? RequiredSystemDiskSize{ get; set; }

        /// <summary>
        /// Image status.
        /// </summary>
        [JsonProperty("BlueprintState")]
        public string BlueprintState{ get; set; }

        /// <summary>
        /// Creation time according to ISO 8601 standard. UTC time is used. 
        /// Format: YYYY-MM-DDThh:mm:ssZ.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Image name.
        /// </summary>
        [JsonProperty("BlueprintName")]
        public string BlueprintName{ get; set; }

        /// <summary>
        /// Whether the image supports automation tools.
        /// </summary>
        [JsonProperty("SupportAutomationTools")]
        public bool? SupportAutomationTools{ get; set; }

        /// <summary>
        /// Memory size required by image in GB.
        /// </summary>
        [JsonProperty("RequiredMemorySize")]
        public long? RequiredMemorySize{ get; set; }

        /// <summary>
        /// ID of the Lighthouse image shared from a CVM image
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// URL of official website of the open-source project
        /// </summary>
        [JsonProperty("CommunityUrl")]
        public string CommunityUrl{ get; set; }

        /// <summary>
        /// Guide documentation URL
        /// </summary>
        [JsonProperty("GuideUrl")]
        public string GuideUrl{ get; set; }

        /// <summary>
        /// Array of IDs of scenes associated with an image
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SceneIdSet")]
        public string[] SceneIdSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BlueprintId", this.BlueprintId);
            this.SetParamSimple(map, prefix + "DisplayTitle", this.DisplayTitle);
            this.SetParamSimple(map, prefix + "DisplayVersion", this.DisplayVersion);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "PlatformType", this.PlatformType);
            this.SetParamSimple(map, prefix + "BlueprintType", this.BlueprintType);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "RequiredSystemDiskSize", this.RequiredSystemDiskSize);
            this.SetParamSimple(map, prefix + "BlueprintState", this.BlueprintState);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "BlueprintName", this.BlueprintName);
            this.SetParamSimple(map, prefix + "SupportAutomationTools", this.SupportAutomationTools);
            this.SetParamSimple(map, prefix + "RequiredMemorySize", this.RequiredMemorySize);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "CommunityUrl", this.CommunityUrl);
            this.SetParamSimple(map, prefix + "GuideUrl", this.GuideUrl);
            this.SetParamArraySimple(map, prefix + "SceneIdSet.", this.SceneIdSet);
        }
    }
}

