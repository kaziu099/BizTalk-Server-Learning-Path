namespace UnitTestingFeatureWithMaps.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"UnitTestingFeatureWithMaps.Schemas.PeopleOrigin", typeof(global::UnitTestingFeatureWithMaps.Schemas.PeopleOrigin))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"UnitTestingFeatureWithMaps.Schemas.PeopleTarget", typeof(global::UnitTestingFeatureWithMaps.Schemas.PeopleTarget))]
    public sealed class ScriptingFunctoidSample : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://HowMapsWorks.PeopleOrigin"" xmlns:ns0=""http://HowMapsWorks.PeopleTarget"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PeopleOrigin"" />
  </xsl:template>
  <xsl:template match=""/s0:PeopleOrigin"">
    <ns0:PeopleTarget>
      <xsl:for-each select=""Employee"">
     <Person>
          <Name>
               <xsl:value-of select=""Name/text()"" /> 
          </Name>
          <Sex>
               <xsl:value-of select=""Sex/text()"" /> 
          </Sex>
     </Person>
</xsl:for-each>
      <xsl:for-each select=""Client"">
     <Person>
          <Name>
               <xsl:value-of select=""Name/text()"" /> 
          </Name>
          <Sex>
               <xsl:value-of select=""Sex/text()"" /> 
          </Sex>
     </Person>
</xsl:for-each>
    </ns0:PeopleTarget>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"UnitTestingFeatureWithMaps.Schemas.PeopleOrigin";
        
        private const global::UnitTestingFeatureWithMaps.Schemas.PeopleOrigin _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"UnitTestingFeatureWithMaps.Schemas.PeopleTarget";
        
        private const global::UnitTestingFeatureWithMaps.Schemas.PeopleTarget _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"UnitTestingFeatureWithMaps.Schemas.PeopleOrigin";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"UnitTestingFeatureWithMaps.Schemas.PeopleTarget";
                return _TrgSchemas;
            }
        }
    }
}
